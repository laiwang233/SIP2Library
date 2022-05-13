using SIP2Client.Common.Sip2Attribute;

namespace SIP2Client.Entities.Sip2Response;
/// <summary>
/// 登录响应类
/// </summary>
public class Sip2LoginResponse : BaseSip2Response
{
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
