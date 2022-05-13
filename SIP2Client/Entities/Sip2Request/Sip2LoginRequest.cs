using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Request;
/// <summary>
/// 登录请求类
/// </summary>
[Sip2Id("93")]
public class Sip2LoginRequest : BaseSip2Request
{
    /// <summary>
    /// uid算法
    /// </summary>
    [Sip2Id("UidAlgorithm", 1)]
    public string UidAlgorithm { get; set; } = "0";
    /// <summary>
    /// pwd算法
    /// </summary>
    [Sip2Id("PwdAlgorithm", 1)]
    public string PwdAlgorithm { get; set; } = "0";
    /// <summary>
    /// 自助机账号
    /// </summary>
    [Sip2Id("CN")]
    public string Sip2UserName { get; set; }
    /// <summary>
    /// 自助机密码
    /// </summary>
    [Sip2Id("CO")]
    public string Sip2Password { get; set; }
    /// <summary>
    /// 位置码
    /// </summary>
    [Sip2Id("CP")]
    public string LocationCode { get; set; }
}
