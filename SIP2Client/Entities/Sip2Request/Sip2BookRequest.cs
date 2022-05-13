using SIP2Client.Common;
using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Request;
/// <summary>
/// 图书信息请求
/// </summary>
[Sip2Id("17")]
public class Sip2BookRequest : BaseSip2Request
{
    /// <summary>
    /// 发送时间
    /// </summary>
    [Sip2Id("TransactionDate", 18)]
    public string TransactionDate { get; set; } = $"{DateTime.Now.ToSipString()}";

    /// <summary>
    /// 图书馆名称
    /// </summary>
    [Sip2Id("AO")]
    public string InstitutionId { get; set; }

    /// <summary>
    /// 图书条码号
    /// </summary>
    [Sip2Id("AB")]
    public string BookBarcode { get; set; }

    /// <summary>
    /// 会话密码
    /// </summary>
    [Sip2Id("AC")]
    public string TerminalPassword { get; set; }
}
