using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Response;

/// <summary>
/// 修改读者密码响应
/// </summary>
public class Sip2ChangeReaderPwdResponse : BaseSip2Response
{
    /// <summary>
    /// 操作结果
    /// </summary>
    public string EndSession { get; set; }
    /// <summary>
    /// 发送日期
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
    /// 失败原因AF
    /// </summary>
    [Sip2Id("AF")]
    public string ScreenMessage { get; set; }
    /// <summary>
    /// 备注AG
    /// </summary>
    [Sip2Id("AG")]
    public string PrintLine { get; set; }

}