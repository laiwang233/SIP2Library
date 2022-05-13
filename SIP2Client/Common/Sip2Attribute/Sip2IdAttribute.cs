namespace SIP2Client.Common.Sip2Attribute;

/// <summary>
/// 约束发送接收实体属性
/// </summary>
public class Sip2IdAttribute : Attribute
{
    /// <summary>
    /// 前缀id
    /// </summary>
    public string Desc { get; set; }
    /// <summary>
    /// 限制字符数
    /// </summary>
    public int Number { get; set; }

    public Sip2IdAttribute(string desc)
    {
        Desc = desc;
    }

    public Sip2IdAttribute(string desc, int number)
    {
        Desc = desc;
        Number = number;
    }
}