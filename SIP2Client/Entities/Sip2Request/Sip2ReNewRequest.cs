using SIP2Client.Common;
using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Request;
/// <summary>
/// 续借请求
/// </summary>
[Sip2Id("29")]
public class Sip2ReNewRequest : BaseSip2Request
{
    /// <summary>
    /// 是否允许第三方续借
    /// </summary>
    [Sip2Id("ThirdPartyAllowed", 1)]
    public string ThirdPartyAllowed { get; set; } = "Y";

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
    /// 续借日期
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
    /// 读者密码
    /// </summary>
    [Sip2Id("AD")]
    public string ReaderPassword { get; set; }

    /// <summary>
    /// 图书条码号
    /// </summary>
    [Sip2Id("AB")]
    public string BookIdentifier { get; set; }

    /// <summary>
    /// 题名
    /// </summary>
    [Sip2Id("AJ")]
    public string TitleIdentifier { get; set; }

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
    /// 自动扣款
    /// </summary>
    [Sip2Id("BO")]
    public string FeeAcknowledged { get; set; } = "N";

}
