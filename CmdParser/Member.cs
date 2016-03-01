using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmdParser;

namespace CmdParser
{
    class Member
    {
        string memberName { get; set; }
        Alt[] alts { get; set; }
    }
}
