using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Response;

/// <summary>
/// 还书信息响应
/// </summary>
public class Sip2ReturnBookResponse : BaseSip2Response
{
    /// <summary>
    /// 操作结果OK
    /// </summary>
    [Sip2Id("OK")]
    public string Ok { get; set; }
    /// <summary>
    /// 是否有磁性
    /// </summary>
    public string Resensitize { get; set; }
    /// <summary>
    /// 是否有磁条
    /// </summary>
    public string MagneticMedia { get; set; }
    /// <summary>
    /// 是否提示
    /// </summary>
    public string Alert { get; set; }
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
    /// 图书条码号AB
    /// </summary>
    [Sip2Id("AB")]
    public string BookIdentifier { get; set; }
    /// <summary>
    /// 索书号AQ
    /// </summary>
    [Sip2Id("AQ")]
    public string PermanentLocation { get; set; }
    /// <summary>
    /// 题名AJ
    /// </summary>
    [Sip2Id("AJ")]
    public string TitleIdentifier { get; set; }
    /// <summary>
    /// 类别CL
    /// </summary>
    [Sip2Id("CL")]
    public string SortBin { get; set; }
    /// <summary>
    /// 读者证号AA
    /// </summary>
    [Sip2Id("AA")]
    public string ReaderIdentifier { get; set; }
    /// <summary>
    /// 图书类型CK
    /// </summary>
    [Sip2Id("CK")]
    public string MediaType { get; set; }
    /// <summary>
    /// 图书属性CH
    /// </summary>
    [Sip2Id("CH")]
    public string BookProperties { get; set; }
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