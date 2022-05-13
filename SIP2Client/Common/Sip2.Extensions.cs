using System.Net.Sockets;
using System.Reflection;
using System.Text;
using Bing.Extensions;
using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Common;

/// <summary>
/// Sip2扩展方法
/// </summary>
internal static class Sip2Extensions
{
    //分隔符
    private const char _fieldTerminator = '|';
    private const char _messageTerminator = '\r';
    private static int seq { get; set; } = -1;

    /// <summary>
    /// 信息传输
    /// </summary>
    /// <param name="clientSocket">连接对象</param>
    /// <param name="message">要传输的信息</param>
    /// <param name="charset">字符编码</param>
    internal static void WriteToStream(this TcpClient clientSocket, string message, string charset)
    {
        Encoding encoding = Encoding.UTF8;
        if (!string.IsNullOrEmpty(charset)) encoding = Encoding.GetEncoding(charset);

        NetworkStream serverStream = clientSocket.GetStream();
        byte[] outStream = encoding.GetBytes(message);
        serverStream.Write(outStream, 0, outStream.Length);
        serverStream.Flush();
    }

    /// <summary>
    /// 信息接收
    /// </summary>
    /// <param name="clientSocket">连接对象</param>
    /// <param name="charset">字符编码</param>
    /// <returns></returns>
    internal static string ReadFromStream(this TcpClient clientSocket, string charset)
    {
        Encoding encoding = Encoding.UTF8;
        try
        {
            if (!string.IsNullOrEmpty(charset))
                encoding = Encoding.GetEncoding(charset);
        }
        catch
        {

        }
        NetworkStream networkStream = clientSocket.GetStream();
        if (networkStream.CanRead)
        {
            // Buffer to store the response bytes.
            byte[] readBuffer = new byte[clientSocket.ReceiveBufferSize];
            string fullServerReply = string.Empty;
            try
            {
                using MemoryStream writer = new MemoryStream();
                while (networkStream.DataAvailable)
                {
                    int numberOfBytesRead = networkStream.Read(readBuffer, 0, readBuffer.Length);
                    if (numberOfBytesRead <= 0)
                    {
                        break;
                    }
                    writer.Write(readBuffer, 0, numberOfBytesRead);
                }
                fullServerReply = encoding.GetString(writer.ToArray());
            }
            catch
            {
                throw;
            }
            return fullServerReply;
        }
        return "";
    }

    /// <summary>
    /// 日期toString
    /// </summary>
    /// <param name="dt">时间类型</param>
    /// <returns></returns>
    internal static string ToSipString(this DateTime dt)
    {
        return dt.ToString("yyyyMMdd    HHmmss");
    }

    /// <summary>
    /// 根据特性给属性赋值
    /// </summary>
    /// <typeparam name="T">要赋值的泛型</typeparam>
    /// <param name="dic">用于赋值的字典</param>
    /// <returns></returns>
    internal static T GetSip2Info<T>(this Dictionary<string, string> dic)
    {
        T obj = Activator.CreateInstance<T>();
        PropertyInfo[] properties = obj.GetType().GetProperties();
        foreach (PropertyInfo propertyInfo in properties)
        {
            Sip2IdAttribute id = typeof(T).GetProperty(propertyInfo.Name)!.GetCustomAttribute<Sip2IdAttribute>() == null ? null : propertyInfo.GetCustomAttribute<Sip2IdAttribute>();
            
            if (id == null) continue;
            for (int i = 0; i < dic.Count; i++)
            {
                propertyInfo.SetValue(obj, dic.GetValueOrDefault(id.Desc), null);
            }
        }

        return obj;
    }

    private static int GetSeqNumber()
    {
        seq = seq == 9 ? 0 : ++seq;
        return seq;
    }

    /// <summary>
    /// 校验和的计算公式
    /// </summary>
    /// <param name="msg"></param>
    /// <returns>核验和的结果</returns>
    private static string CalculateChecksum(string msg)
    {
        int checksum = 0;

        foreach (char c in msg)
        {
            checksum += c;
        }

        checksum *= -1;
        string hex = $"{Convert.ToUInt64(Convert.ToString(checksum, 2), 2):X2}";
        return hex[^4..];
    }

    /// <summary>
    /// 将请求类的属性的值提取出来拼接到字符串上
    /// </summary>
    /// <typeparam name="TRequest">请求泛型</typeparam>
    /// <param name="tRequest">请求类</param>
    /// <returns></returns>
    internal static string GetSip2Send<TRequest>(this TRequest tRequest)
    {
        StringBuilder sendMessage = new();
        sendMessage.Clear();
        //加开头的数字,用来标识是什么操作
        sendMessage.Append(typeof(TRequest).GetCustomAttribute<Sip2IdAttribute>()?.Desc);

        PropertyInfo[] properties = tRequest.GetType().GetProperties();
        
        foreach (PropertyInfo propertyInfo in properties)
        {
            Sip2IdAttribute id = propertyInfo.GetCustomAttribute<Sip2IdAttribute>();

            if (id == null) continue;

            var pValue = propertyInfo.GetValue(tRequest).SafeString();

            //是否限制字符数且Attribute和属性名相同
            if (id.Number != 0 && id.Desc.Equals(propertyInfo.Name))
            {
                sendMessage.Append(pValue.PadRight(id.Number));
                continue;
            }

            //是否限制字符数
            if (id.Number != 0)
            {
                sendMessage.Append(id.Desc + pValue.PadRight(id.Number) + _fieldTerminator);
                continue;
            }

            //如果都不是就是带前缀id的属性
            sendMessage.Append(id.Desc + pValue + _fieldTerminator);
        }

        //加末尾
        sendMessage.Append("AY" + GetSeqNumber());
        sendMessage.Append("AZ");
        sendMessage.Append(CalculateChecksum(sendMessage.ToString()));
        sendMessage.Append(_messageTerminator);
        return sendMessage.ToString();
    }

    #region Search(搜索字符串中间内容)

    /// <summary>
    /// 搜索字符串中间内容
    /// </summary>
    /// <param name="source">完整的内容</param>
    /// <param name="left">左边的内容</param>
    /// <param name="right">右边的内容</param>
    /// <returns></returns>
    internal static string Search(this string source, string left, string right)  //获取搜索到的数目  
    {
        try
        {
            int n1 = source.IndexOf(left, 0, StringComparison.Ordinal);
            if (n1 < 0) return null;
            n1 += left.Length;

            int n2 = source.IndexOf(right, n1, StringComparison.Ordinal);

            return n2 < 0 ? null : source[n1..n2];
        }
        catch (Exception)
        {
            return null;
        }

    }

    #endregion


}
