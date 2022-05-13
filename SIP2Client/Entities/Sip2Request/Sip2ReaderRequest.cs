using SIP2Client.Common;
using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Request;
/// <summary>
/// 读者信息请求类
/// </summary>
[Sip2Id("63")]
public class Sip2ReaderRequest : BaseSip2Request
{
    /// <summary>
    /// 语言
    /// </summary>
    [Sip2Id("Language", 3)]
    public string Language { get; set; } = "001";

    /// <summary>
    /// 发送时间
    /// </summary>
    [Sip2Id("TransactionDate", 18)]
    public string TransactionDate { get; set; } = $"{DateTime.Now.ToSipString()}";

    /// <summary>
    /// 图书类型
    /// </summary>
    [Sip2Id("Summary", 10)]
    public string Summary { get; set; } = "none";
    /// <summary>
    /// 图书馆名称AO
    /// </summary>
    [Sip2Id("AO")]
    public string InstitutionId { get; set; }
    /// <summary>
    /// 读者证号AA
    /// </summary>
    [Sip2Id("AA")]
    public string ReaderBarcode { get; set; }
    /// <summary>
    /// 会话密码AC
    /// </summary>
    [Sip2Id("AC")]
    public string TerminalPassword { get; set; }
    /// <summary>
    /// 读者密码AD
    /// </summary>
    [Sip2Id("AD")]
    public string ReaderPin { get; set; }
    /// <summary>
    /// 开始记录号BP
    /// </summary>
    [Sip2Id("BP")]
    public string BP { get; set; }
    /// <summary>
    /// 结束记录号BQ
    /// </summary>
    [Sip2Id("BQ")]
    public string BQ { get; set; }
}
