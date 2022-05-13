using SIP2Client.Common;
using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Request;
/// <summary>
/// 修改读者密码请求
/// </summary>
[Sip2Id("21")]
public class Sip2ChangeReaderPwdRequest : BaseSip2Request
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
    /// 读者证号
    /// </summary>
    [Sip2Id("AA")]
    public string ReaderIdentifier { get; set; }

    /// <summary>
    /// 会话密码
    /// </summary>
    [Sip2Id("AC")]
    public string TerminalPassword { get; set; }

    /// <summary>
    /// 读者原密码
    /// </summary>
    [Sip2Id("AD")]
    public string ReaderPassword { get; set; }

    /// <summary>
    /// 读者新密码
    /// </summary>
    [Sip2Id("AN")]
    public string NewReaderPassword { get; set; }

}
