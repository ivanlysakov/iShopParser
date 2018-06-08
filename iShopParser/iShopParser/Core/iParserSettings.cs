using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iShopParser.Core
{
    interface iParserSettings
    {
        string BaseURL { get; set;}
        string Prefix { get; set;}
        int StartPoint { get; set;}
        int EndPoint { get; set;}
    }
}
