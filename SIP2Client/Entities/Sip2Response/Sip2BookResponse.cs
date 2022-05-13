
using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Response;

/// <summary>
/// 查询图书信息响应
/// </summary>
public class Sip2BookResponse : BaseSip2Response
{
    //没有加该字段因为返回的信息没有id标识 hold queue length CF

    /// <summary>
    /// 图书状态
    /// </summary>
    public string CirculationStatus { get; set; }

    public string SecurityMarker { get; set; }
    public string FeeType { get; set; }

    /// <summary>
    /// 发送时间
    /// </summary>
    public string TransactionDate { get; set; }
    /// <summary>
    /// 到期日期AH
    /// </summary>
    [Sip2Id("AH")]
    public string DueDate { get; set; }
    /// <summary>
    /// 续借日期CJ
    /// </summary>
    [Sip2Id("CJ")]
    public string RecallDate { get; set; }
    /// <summary>
    /// 借阅日期CM
    /// </summary>
    [Sip2Id("CM")]
    public string HoldPickupDate { get; set; }
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
    /// 责任者AR
    /// </summary>
    [Sip2Id("AR")]
    public string Author { get; set; }
    /// <summary>
    /// 借阅者BG
    /// </summary>
    [Sip2Id("BG")]
    public string Owner { get; set; }
    /// <summary>
    /// 货币类型BH
    /// </summary>
    [Sip2Id("BH")]
    public string CurrencyType { get; set; }
    /// <summary>
    /// 图书价格BV
    /// </summary>
    [Sip2Id("BV")]
    public string FeeAmount { get; set; }
    /// <summary>
    /// 超期罚款金额OD
    /// </summary>
    [Sip2Id("OD")]
    public string OverdueAmerce { get; set; }
    /// <summary>
    /// 媒体类型CK
    /// </summary>
    [Sip2Id("CK")]
    public string MediaType { get; set; }
    /// <summary>
    /// 索书号AQ
    /// </summary>
    [Sip2Id("AQ")]
    public string PermanentLocation { get; set; }
    /// <summary>
    /// 馆藏地AP
    /// </summary>
    [Sip2Id("AP")]
    public string CurrentLocation { get; set; }
    /// <summary>
    /// 图书类型CH
    /// </summary>
    [Sip2Id("CH")]
    public string BookProperties { get; set; }
    /// <summary>
    /// 出版社CT
    /// </summary>
    [Sip2Id("CT")]
    public string BookConcern { get; set; }
    /// <summary>
    /// 附件状态CS
    /// </summary>
    [Sip2Id("CS")]
    public string Accessory { get; set; }
    /// <summary>
    /// 不可借原因AF
    /// </summary>
    [Sip2Id("AF")]
    public string ScreenMessage { get; set; }
    /// <summary>
    /// 备注AG
    /// </summary>
    [Sip2Id("AG")]
    public string PrintLine { get; set; }
}