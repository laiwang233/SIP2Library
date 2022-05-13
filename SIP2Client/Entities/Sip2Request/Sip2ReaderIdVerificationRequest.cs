using SIP2Client.Common;
using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Request;
/// <summary>
/// 读者证号/身份证号查重验证请求
/// </summary>
[Sip2Id("91")]
public class Sip2ReaderIdVerificationRequest : BaseSip2Request
{
    /// <summary>
    /// 发送日期
    /// </summary>
    [Sip2Id("TransactionDate", 18)]
    public string TransactionDate { get; set; } = $"{DateTime.Now.ToSipString()}";
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
    /// 身份证号
    /// </summary>
    [Sip2Id("XO")]
    public string IdNumber { get; set; }
    /// <summary>
    /// 验证方式
    /// </summary>
    [Sip2Id("XK")]
    public string VerificationMethod { get; set; }
}
