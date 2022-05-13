using System.Net.Sockets;
using System.Text;
using Bing.Extensions;
using SIP2Client.Common;
using SIP2Client.Entities;
using SIP2Client.Entities.Sip2Request;
using SIP2Client.Entities.Sip2Response;
using static Bing.Helpers.Enum;

namespace SIP2Client.Codes;

/// <summary>
/// Sip2发送接收信息类
/// </summary>
public class Sip2Client
{
    //启用GBK字符编码支持
    static Sip2Client()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    }

    #region 语言代码
    //未知（默认）000
    //英语001
    //    法语002
    //德语003
    //    意大利语004
    //荷兰005
    //    瑞典语006
    //芬兰语007
    //    西班牙语008
    //丹麦009
    //    葡萄牙语010
    //加拿大法语011
    //    挪威012
    //希伯来语013
    //    日语014
    //俄罗斯015
    //    阿拉伯语016
    //波兰017
    //    希腊语018
    //中文019
    //    韩语020
    //北美西班牙语021
    //    泰米尔022
    //马来语023
    //    英国024
    //冰岛025
    //    比利时026
    //台湾027
    #endregion
    /// <summary>
    /// 语言(基于语言代码)
    /// </summary>
    private string language { get; set; } = "001";
    /// <summary>
    /// ip地址
    /// </summary>
    protected string hostname { get; set; }
    /// <summary>
    /// 端口
    /// </summary>
    protected int port { get; set; }
    protected string AP { get; set; } = ""; //current location
    protected string AO { get; set; } = ""; //institution id
    protected string AC { get; set; } = ""; //terminal password
    /// <summary>
    /// 连接对象
    /// </summary>
    protected TcpClient tcpClient { get; set; }
    /// <summary>
    /// 传输字符串
    /// </summary>
    private StringBuilder messageBuilder { get; set; } = new StringBuilder();
    private bool noFixed { get; set; } = false;
    /// <summary>
    /// 编码
    /// </summary>
    protected string charSet { get; set; } = "";
    /// <summary>
    /// 判断是否连接
    /// </summary>
    private bool _inited = false;
    public bool Inited => (tcpClient?.Connected ?? false) && _inited;


    public Sip2Model CompareSip2Model { get; set; }

    ~Sip2Client()
    {
        _inited = false;
        Close();
    }

    #region 信息封装

    /// <summary>
    /// 发送信息,并将响应信息提取
    /// </summary>
    /// <typeparam name="TRequest">请求泛型</typeparam>
    /// <param name="tRequest">请求实体</param>
    /// <returns></returns>
    protected virtual Sip2Transaction SendMessage<TRequest>(TRequest tRequest)
    {
        //拼接发送信息字符串
        string msg = tRequest.GetSip2Send();

        //用于存储带有前缀字段的响应数据
        Dictionary<string, string> field = new();

        //发送请求字符串
        tcpClient.WriteToStream(msg, charSet);
        string response = string.Empty;
        DateTime start = DateTime.Now;
        while (!response.EndsWith("\r"))
        {
            if ((DateTime.Now - start).TotalSeconds > 10)
            {
                response = "Sip2接收数据超时";
                break;
            }
            //接收响应字符串
            response += tcpClient.ReadFromStream(charSet);
        }

        //将字符串封装成字典类
        string[] split = response.Split('|');
        foreach (string s in split)
        {
            if (s.Length >= 2)
            {
                field.Add(s[..2], s[2..]);
            }
        }

        return new Sip2Transaction() { ResponseMessage = response, Field = field, SendMessage = msg };
    }

    /// <summary>
    /// 获取返回结果
    /// </summary>
    /// <typeparam name="TResponse">响应泛型</typeparam>
    /// <typeparam name="TRequest">请求泛型</typeparam>
    /// <param name="tRequest">请求实体</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public virtual Sip2Result<TResponse> GetResult<TResponse, TRequest>(TRequest tRequest) 
        where TResponse : BaseSip2Response
        where TRequest : BaseSip2Request
    {
        if (!Inited) throw new Exception("发送失败，请确保连接到服务器或登录！");
        //获取响应信息
        Sip2Transaction sip2Transaction = SendMessage(tRequest);
        //赋值
        TResponse info = sip2Transaction.Field.GetSip2Info<TResponse>();
        //验证操作是否成功
        ErrorCode error = info.Valid(sip2Transaction);

        //返回信息类
        return new Sip2Result<TResponse>()
        {
            Info = info,
            SendMessage = sip2Transaction.SendMessage,
            ResponseMessage = sip2Transaction.ResponseMessage,
            MessageCode = $"{GetDescription<ErrorCode>(error)} : {error}"
        };
    }

    #endregion

    #region 方法

    /// <summary>
    /// 释放资源
    /// </summary>
    protected virtual void Close()
    {
        if (tcpClient != null)
        {
            tcpClient.Close();
            GC.SuppressFinalize(tcpClient);
            tcpClient = null;
        }
    }

    #endregion

    #region 业务方法

    /// <summary>
    /// 连接初始化
    /// </summary>
    /// <param name="sip2Info">连接信息类</param>
    public bool Init(Sip2Model sip2Info)
    {
        //如果没有连接就连接
        if (sip2Info != null && !_inited)
        {
            try
            {
                //如果ip和端口号不为空，则进行连接初始化
                if (!sip2Info.Ip.IsEmpty() && !sip2Info.Port.IsEmpty())
                {
                    hostname = sip2Info.Ip;
                    port = int.Parse(sip2Info.Port);
                    AO = sip2Info.AO;
                    AP = sip2Info.AP;
                    charSet = sip2Info.Encoding;
                    tcpClient = new TcpClient();
                    tcpClient.Connect(hostname, port);
                    _inited = true;
                }
               
            }
            catch
            {
                _inited = false;
                Close();
            }

            //判断是否登录
            if (sip2Info.IsLogin)
            {
                Sip2Result<Sip2LoginResponse> loginRes = GetResult<Sip2LoginResponse, Sip2LoginRequest>(new Sip2LoginRequest()
                {
                    Sip2UserName = sip2Info.Uid,
                    Sip2Password = sip2Info.Pwd,
                    LocationCode = sip2Info.CP
                });

                //判断是否登录失败,如果失败则断开连接
                if (loginRes.MessageCode.Contains("失败"))
                {
                    _inited = false;
                    Close();
                }
            }
        }

        return Inited;
    }

    #endregion

}
