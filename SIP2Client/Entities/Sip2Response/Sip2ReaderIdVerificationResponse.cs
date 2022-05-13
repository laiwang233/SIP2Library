using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Response;

/// <summary>
/// 读者证号/身份证号查重响应
/// </summary>
public class Sip2ReaderIdVerificationResponse : BaseSip2Response
{
    /// <summary>
    /// 是否处理成功Ok(0不成功，1成功)
    /// </summary>
    [Sip2Id("OK")]
    public string Ok { get; set; }
    /// <summary>
    /// 发送时间
    /// </summary>
    public string TransactionDate { get; set; }
    /// <summary>
    /// 图书馆名称AO
    /// </summary>
    [Sip2Id("AO")]
    public string InstitutionId { get; set; }
    /// <summary>
    /// 读者证号AA
    /// </summary>
    [Sip2Id("AA")]
    public string ReaderIdentifier { get; set; }
    /// <summary>
    /// 身份证号XO
    /// </summary>
    [Sip2Id("XO")]
    public string IdNumber { get; set; }
    /// <summary>
    /// 验证方式XK(0验证读者证号，1验证身份证号)
    /// </summary>
    [Sip2Id("XK")]
    public string VerificationMethod { get; set; }
    /// <summary>
    /// 验证结果AC(0不存在，1存在)
    /// </summary>
    [Sip2Id("AC")]
    public string Result { get; set; }

}