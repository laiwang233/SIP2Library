
using SIP2Client.Common;
using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Request;

/// <summary>
/// 读者注册请求
/// </summary>
[Sip2Id("81")]
public class Sip2ReaderRegisterRequest : BaseSip2Request
{
    /// <summary>
    /// 发送时间
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
    /// 读者密码
    /// </summary>
    [Sip2Id("AD")]
    public string ReaderPassword { get; set; }

    /// <summary>
    /// 读者姓名
    /// </summary>
    [Sip2Id("AE")]
    public string ReaderName { get; set; }

    /// <summary>
    /// 读者开户馆
    /// </summary>
    [Sip2Id("AM")]
    public string ReaderOpenAccountLibrary { get; set; }

    /// <summary>
    /// 座机号码
    /// </summary>
    [Sip2Id("BP")]
    public string LandlineNumber { get; set; }

    /// <summary>
    /// 手机号码
    /// </summary>
    [Sip2Id("MP")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// 电子邮箱
    /// </summary>
    [Sip2Id("BE")]
    public string Email { get; set; }

    /// <summary>
    /// 读者地址
    /// </summary>
    [Sip2Id("BD")]
    public string ReaderAddress { get; set; }

    /// <summary>
    /// 身份证号
    /// </summary>
    [Sip2Id("XO")]
    public string IdNumber { get; set; }

    /// <summary>
    /// 读者类型
    /// </summary>
    [Sip2Id("XT")]
    public string ReaderType { get; set; } = "01";

    /// <summary>
    /// 办证押金
    /// </summary>
    [Sip2Id("BV")]
    public string CertificateDeposit { get; set; }

    /// <summary>
    /// 读者证办证日期
    /// </summary>
    [Sip2Id("XB")]
    public string ReaderProcessingDate { get; set; } = $"{DateTime.Now:yyyyMMdd}";

    /// <summary>
    /// 出生日期
    /// </summary>
    [Sip2Id("XH")]
    public string DateOfBirth { get; set; }

    /// <summary>
    /// 民族
    /// </summary>
    [Sip2Id("XN")]
    public string Nation { get; set; }

    /// <summary>
    /// 籍贯
    /// </summary>
    [Sip2Id("XP")]
    public string NativePlace { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    [Sip2Id("XF")]
    public string Remarks { get; set; }

    /// <summary>
    /// 读者证有效日期
    /// </summary>
    [Sip2Id("XD")]
    public string ReaderEffectiveDate { get; set; }

    /// <summary>
    /// 读者证启用日期
    /// </summary>
    [Sip2Id("XE")]
    public string ReaderStartDate { get; set; } = $"{DateTime.Now:yyyyMMdd}";

    /// <summary>
    /// 读者性别
    /// </summary>
    [Sip2Id("XM", 1)]
    public string Sex { get; set; } = "1";

    /// <summary>
    /// 新读者证号
    /// </summary>
    [Sip2Id("XA")]
    public string NewReaderId { get; set; }

    /// <summary>
    /// 操作方式
    /// </summary>
    [Sip2Id("XK", 2)]
    public string OperationMode { get; set; }
}