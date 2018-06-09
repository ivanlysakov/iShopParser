using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iShopParser.Models
{
    public class Items
    {
    public Guid Id { get; set; }
    public string itemHeader { get; set; }
    public string itemPrice { get; set; }
    public string itemImage { get; set; }
    public Dictionary<string, string> itemProps { get; set; }
        
    }
}
