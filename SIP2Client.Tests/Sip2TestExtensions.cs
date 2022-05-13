namespace SIP2Client.Tests;
public static class Sip2TestExtensions
{
    /// <summary>
    /// 日期toString
    /// </summary>
    /// <param name="dt"></param>
    /// <returns></returns>
    internal static string ToSipString(this DateTime dt)
    {
        return dt.ToString("yyyyMMdd    HHmmss");
    }

    public static Dictionary<string, string> Summary = new()
    {
        ["none"] = "      ",
        ["hold"] = "Y     ",
        ["overdue"] = " Y    ",
        ["charged"] = "  Y   ",
        ["fine"] = "   Y  ",
        ["recall"] = "    Y ",
        ["unavail"] = "     Y"
    };
}
