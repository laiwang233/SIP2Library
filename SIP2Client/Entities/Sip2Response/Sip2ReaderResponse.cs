using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Response;

/// <summary>
/// 读者信息响应
/// </summary>
public class Sip2ReaderResponse : BaseSip2Response
{
    /// <summary>
    /// 读者状态
    /// </summary>
    public string ReaderStatus { get; set; }
    /// <summary>
    /// 语言代码
    /// </summary>
    public string Language { get; set; }
    /// <summary>
    /// 发送时间
    /// </summary>
    public string TransactionDate { get; set; }
    /// <summary>
    /// 共可借数量
    /// </summary>
    public string HoldBookCount { get; set; }
    /// <summary>
    /// 超期数量
    /// </summary>
    public string OverdueBookCount { get; set; }
    /// <summary>
    /// 在借数量
    /// </summary>
    public string ChargedBookCount { get; set; }
    /// <summary>
    /// 需罚款的在借数量
    /// </summary>
    public string FineBookCount { get; set; }

    public string RecallBookCount { get; set; }
    public string UnavailableHoldsCount { get; set; }

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
    /// 读者名称AE
    /// </summary>
    [Sip2Id("AE")]
    public string ReaderName { get; set; }
    /// <summary>
    /// 仍可借数量BZ
    /// </summary>
    [Sip2Id("BZ")]
    public string HoldBookLimit { get; set; }

    /// <summary>
    /// CA
    /// </summary>
    [Sip2Id("CA")]
    public string OverdueBookLimit { get; set; }
    /// <summary>
    /// CB
    /// </summary>
    [Sip2Id("CB")]
    public string ChargedBookLimit { get; set; }

    /// <summary>
    /// 读者证号是否存在BL
    /// </summary>
    [Sip2Id("BL")]
    public string ValidReader { get; set; }
    /// <summary>
    /// 密码是否有效CQ
    /// </summary>
    [Sip2Id("CQ")]
    public string ValidReaderPassword { get; set; }
    /// <summary>
    /// 读者卡类型CT
    /// </summary>
    [Sip2Id("CT")]
    public string CardType { get; set; }
    /// <summary>
    /// 货币类型BH
    /// </summary>
    [Sip2Id("BH")]
    public string CurrencyType { get; set; }
    /// <summary>
    /// 押金BV
    /// </summary>
    [Sip2Id("BV")]
    public string FeeAmount { get; set; }
    /// <summary>
    /// 卡内余额CC
    /// </summary>
    [Sip2Id("CC")]
    public string FeeLimit { get; set; }
    /// <summary>
    /// 欠费金额AR
    /// </summary>
    [Sip2Id("AR")]
    public string ArReaRage { get; set; }
    /// <summary>
    /// 预约图书序列AS
    /// </summary>
    [Sip2Id("AS")]
    public string HoldBook { get; set; }
    /// <summary>
    /// 超期图书AT
    /// </summary>
    [Sip2Id("AT")]
    public string OverdueBook { get; set; }
    /// <summary>
    /// 在借图书AU
    /// </summary>
    [Sip2Id("AU")]
    public string ChargedBook { get; set; }
    /// <summary>
    /// 需罚款图书AV
    /// </summary>
    [Sip2Id("AV")]
    public string FineBook { get; set; }
    /// <summary>
    /// 身份证号IC
    /// </summary>
    [Sip2Id("IC")]
    public string IdentifyCard { get; set; }
    /// <summary>
    /// 通讯地址BD
    /// </summary>
    [Sip2Id("BD")]
    public string HomeAddress { get; set; }
    /// <summary>
    /// 邮箱BE
    /// </summary>
    [Sip2Id("BE")]
    public string EmailAddress { get; set; }
    /// <summary>
    /// 联系电话BF
    /// </summary>
    [Sip2Id("BF")]
    public string HomePhoneNumber { get; set; }
    /// <summary>
    /// 错误原因AF
    /// </summary>
    [Sip2Id("AF")]
    public string ScreenMessage { get; set; }
    /// <summary>
    /// 备注AG
    /// </summary>
    [Sip2Id("AG")]
    public string PrintLine { get; set; }

}