namespace SIP2Client.Entities;
/// <summary>
/// 返回信息类
/// </summary>
/// <typeparam name="T">响应实体</typeparam>
public class Sip2Result<T>
{
    /// <summary>
    /// 响应实体
    /// </summary>
    public T Info { get; set; }
    /// <summary>
    /// 发送信息
    /// </summary>
    public string SendMessage { get; set; }
    /// <summary>
    /// 响应信息
    /// </summary>
    public string ResponseMessage { get; set; }
    /// <summary>
    /// 错误码
    /// error msg : error code
    /// </summary>
    public string MessageCode { get; set; }

}
