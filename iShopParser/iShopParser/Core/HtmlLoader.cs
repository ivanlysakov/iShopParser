using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace iShopParser.Core
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;
        
        public HtmlLoader (iParserSettings settings)
        { 
            client = new HttpClient();
            url = $"{settings.BaseURL}/{settings.Prefix}";
        }

        public async Task<string> GetSourceByCategoryId(int id)
        { 
            var currentURL = url.Replace("{CurrentId}",id.ToString());
            var response = await client.GetAsync(currentURL);
            string source = null;

            if (response!=null && response.StatusCode == HttpStatusCode.OK)
                { 
                source = await response.Content.ReadAsStringAsync();
                }
            return source;
        }
    }
}
