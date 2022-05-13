namespace SIP2Client.Entities;

/// <summary>
/// 响应信息类
/// </summary>
public class Sip2Transaction
{
    /// <summary>
    /// 发送信息字符串
    /// </summary>
    public string SendMessage { get; set; }
    /// <summary>
    /// 响应信息字符串
    /// </summary>
    public string ResponseMessage { get; set; }
    /// <summary>
    /// 根据前缀id提取的信息 例如CT, XX出版社
    /// </summary>
    public Dictionary<string, string> Field { get; set; }

}