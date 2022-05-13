using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2Client.Common;
public class Sip2Const
{
    //查询读者信息的Summary字段

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
