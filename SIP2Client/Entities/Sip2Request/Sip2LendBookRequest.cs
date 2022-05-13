using SIP2Client.Common;
using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Request;
/// <summary>
/// 借书请求
/// </summary>
[Sip2Id("11")]
public class Sip2LendBookRequest : BaseSip2Request
{
    /// <summary>
    /// 是否允许续借
    /// </summary>
    [Sip2Id("RenewalOk", 1)]
    public string RenewalOk { get; set; } = "Y";

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
    /// 借阅日期
    /// </summary>
    [Sip2Id("NbDueDate", 18)]
    public string NbDueDate { get; set; }

    /// <summary>
    /// 图书馆名称
    /// </summary>
    [Sip2Id("AO")]
    public string InstitutionId { get; set; }

    /// <summary>
    /// 读者证号
    /// </summary>
    [Sip2Id("AA")]
    public string ReaderIdentifier { get; set; }

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
    public string BookProperties { get; set; } = "001";

    /// <summary>
    /// 读者密码
    /// </summary>
    [Sip2Id("AD")]
    public string ReaderPassword { get; set; }

    /// <summary>
    /// 自动扣款
    /// </summary>
    [Sip2Id("BO")]
    public string FeeAcknowledged { get; set; } = "N";

    /// <summary>
    /// 退出
    /// </summary>
    [Sip2Id("BI")]
    public string Cancel { get; set; } = "N";

}
