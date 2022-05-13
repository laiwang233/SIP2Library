using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Response;
/// <summary>
/// 读者注册响应
/// </summary>
public class Sip2ReaderRegisterResponse : BaseSip2Response
{
    /// <summary>
    /// 是否处理成功OK
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
    /// 财金流水记录号JK
    /// </summary>
    [Sip2Id("JK")]
    public string FinancialRecord { get; set; }
    /// <summary>
    /// 显示屏幕信息AF
    /// </summary>
    [Sip2Id("AF")]
    public string ScreenMessage { get; set; }
}
