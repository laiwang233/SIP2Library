using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Response;

/// <summary>
/// 图书信息更新响应
/// </summary>
public class Sip2ChangeBookResponse : BaseSip2Response
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
    /// 图书条码号AA
    /// </summary>
    [Sip2Id("AA")]
    public string BookIdentifier { get; set; }
    /// <summary>
    /// 更新的字段UF
    /// </summary>
    [Sip2Id("UF")]
    public string UpdateField { get; set; }
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