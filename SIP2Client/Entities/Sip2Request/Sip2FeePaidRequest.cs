using SIP2Client.Common;
using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Request;
/// <summary>
/// 欠费缴纳请求
/// </summary>
[Sip2Id("37")]
public class Sip2FeePaidRequest : BaseSip2Request
{
    /// <summary>
    /// 发送日期
    /// </summary>
    [Sip2Id("TransactionDate", 18)]
    public string TransactionDate { get; set; } = $"{DateTime.Now.ToSipString()}";

    /// <summary>
    /// 欠费类型
    /// </summary>
    [Sip2Id("FeeType", 2)]
    public string FeeType { get; set; } = "00";

    /// <summary>
    /// 支付类型
    /// </summary>
    [Sip2Id("PaymentType", 2)]
    public string PaymentType { get; set; } = "00";

    /// <summary>
    /// 货币类型
    /// </summary>
    [Sip2Id("BH", 3)]
    public string CurrencyType { get; set; } = "RMB";

    /// <summary>
    /// 金额
    /// </summary>
    [Sip2Id("BV")]
    public string Amount { get; set; }

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
    /// 会话密码
    /// </summary>
    [Sip2Id("AC")]
    public string TerminalPassword { get; set; }

    /// <summary>
    /// 读者密码
    /// </summary>
    [Sip2Id("AD")]
    public string ReaderPassword { get; set; }

    /// <summary>
    /// 支付方式
    /// </summary>
    [Sip2Id("CG")]
    public string FeeIdentifier { get; set; }

    /// <summary>
    /// 支付流水号
    /// </summary>
    [Sip2Id("BK")]
    public string TransactionId { get; set; }

}
