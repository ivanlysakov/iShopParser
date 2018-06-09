using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp.Dom.Html;

namespace iShopParser.Core.ShopParser
{
    class ShopParser : iParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var items = document.QuerySelectorAll("div").Where(item => item.ClassName !=null && item.ClassName.Contains("name"));
            
            var list = new List<string>();
            foreach (var item in items)
            {
                list.Add (item.TextContent);
            }
            return list.ToArray();
        }
    }
}
