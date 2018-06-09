

namespace iShopParser.Core.ShopParser
{
    class ShopParserSettings : iParserSettings
    {
        
        public ShopParserSettings (int start, int end)
        { 
            StartPoint = start;
            EndPoint = end;
        }
        
        public string BaseURL   {get; set; } = "http://bdjilka.kiev.ua";
        public string Prefix    {get; set; } = "category/view/{CurrentId}";
        public int StartPoint   {get; set; }
        public int EndPoint     {get; set; }
    }
}
