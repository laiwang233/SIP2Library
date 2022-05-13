using SIP2Client.Common;
using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Request;
/// <summary>
/// 还书请求
/// </summary>
[Sip2Id("09")]
public class Sip2ReturnBookRequest : BaseSip2Request
{
    /// <summary>
    /// 阻止
    /// </summary>
    [Sip2Id("NoBlock", 1)]
    public string NoBlock { get; set; } = "N";

    /// <summary>
    /// 发送日期
    /// </summary>
    [Sip2Id("TransactionDate", 18)]
    public string TransactionDate { get; set; } = $"{DateTime.Now.ToSipString()}";

    /// <summary>
    /// 还书日期
    /// </summary>
    [Sip2Id("ReturnDate", 18)]
    public string ReturnDate { get; set; }

    /// <summary>
    /// 图书当前位置
    /// </summary>
    [Sip2Id("AP")]
    public string CurrentLocation { get; set; }

    /// <summary>
    /// 图书馆名称 
    /// </summary>
    [Sip2Id("AO")]
    public string InstitutionId { get; set; }

    /// <summary>
    /// 图书条码号
    /// </summary>
    [Sip2Id("AB")]
    public string BookIdentifier { get; set; }

    /// <summary>
    /// 会话密码 
    /// </summary>
    [Sip2Id("AC")]
    public string TerminalPassword { get; set; }

    /// <summary>
    /// 媒体类型 
    /// </summary>
    [Sip2Id("CH")]
    public string BooKProperties { get; set; } = "001";

    /// <summary>
    /// 退出 
    /// </summary>
    [Sip2Id("BI")]
    public string Cancel { get; set; } = "N";

}
