using SIP2Client.Common;
using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Request;
/// <summary>
/// 图书信息更新请求
/// </summary>
[Sip2Id("27")]
public class Sip2ChangeBookRequest : BaseSip2Request
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
    /// 图书条码号
    /// </summary>
    [Sip2Id("AB")]
    public string BookIdentifier { get; set; }

    /// <summary>
    /// 更新字段
    /// </summary>
    [Sip2Id("UF")]
    public string UpdateField { get; set; }

    /// <summary>
    /// 更新新值
    /// </summary>
    [Sip2Id("FV")]
    public string FieldValue { get; set; }

}
