using AngleSharp.Dom.Html;

namespace iShopParser.Core
{
    interface iParser<T> where T : class
    {
    
       T Parse (IHtmlDocument document); 
        
    }
}
