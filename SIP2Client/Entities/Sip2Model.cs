namespace SIP2Client.Entities;

/// <summary>
/// Sip2信息类
/// </summary>
public record Sip2Model
{
    /// <summary>
    /// id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Sip2服务器名称
    /// </summary>
    public string Sip2Name { get; set; }
    /// <summary>
    /// ip地址
    /// </summary>
    public string Ip { get; set; }
    /// <summary>
    /// 端口号
    /// </summary>
    public string Port { get; set; }
    /// <summary>
    /// 字符编码
    /// </summary>
    public string Encoding { get; set; }
    /// <summary>
    /// 用户名
    /// </summary>
    public string Uid { get; set; }
    /// <summary>
    /// 密码
    /// </summary>
    public string Pwd { get; set; }
    /// <summary>
    /// 图书馆名称
    /// </summary>
    public string AO { get; set; }
    /// <summary>
    /// 馆藏地
    /// </summary>
    public string AP { get; set; }
    /// <summary>
    /// 工作台ID
    /// </summary>
    public string CP { get; set; }
    /// <summary>
    /// 是否需要登录
    /// </summary>
    public bool IsLogin { get; set; } = false;
}
