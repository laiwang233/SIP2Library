using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Response;

/// <summary>
/// 借书信息响应
/// </summary>
public class Sip2LendBookResponse : BaseSip2Response
{
    /// <summary>
    /// 操作结果
    /// </summary>
    public string Ok { get; set; }
    /// <summary>
    /// 是否续借成功
    /// </summary>
    public string RenewalOk { get; set; }
    /// <summary>
    /// 是否有磁性
    /// </summary>
    public string MagneticMedia { get; set; }
    /// <summary>
    /// 是否有磁条
    /// </summary>
    public string Desensitize { get; set; }
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
    /// 图书条码号AB
    /// </summary>
    [Sip2Id("AB")]
    public string BookIdentifier { get; set; }
    /// <summary>
    /// 题名AJ
    /// </summary>
    [Sip2Id("AJ")]
    public string TitleIdentifier { get; set; }
    /// <summary>
    /// 应还日期AH
    /// </summary>
    [Sip2Id("AH")]
    public string DueDate { get; set; }
    /// <summary>
    /// 借阅类型BT
    /// </summary>
    [Sip2Id("BT")]
    public string FeeType { get; set; }
    /// <summary>
    /// 权限限制CI
    /// </summary>
    [Sip2Id("CI")]
    public string SecurityInhibit { get; set; }
    /// <summary>
    /// 价格单位BH
    /// </summary>
    [Sip2Id("BH")]
    public string CurrencyType { get; set; }
    /// <summary>
    /// 借阅金额BV
    /// </summary>
    [Sip2Id("BV")]
    public string FeeAmount { get; set; }
    /// <summary>
    /// 媒体类型CK
    /// </summary>
    [Sip2Id("CK")]
    public string MediaType { get; set; }
    /// <summary>
    /// 图书类型CH
    /// </summary>
    [Sip2Id("CH")]
    public string BookProperties { get; set; }
    /// <summary>
    /// 交易记录号BK
    /// </summary>
    [Sip2Id("BK")]
    public string TransactionId { get; set; }
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