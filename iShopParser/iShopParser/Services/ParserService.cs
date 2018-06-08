using iShopParser.Core;
using iShopParser.Core.ShopParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iShopParser.Services
{
    public class ParserService
    {
    
        ParserWorker <string[]> parser;

        public List<string[]> ListTitles;
        
        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            ListTitles.Add(arg2);
        }
        
        private void Parser_OnCompleted(object obj)
        {
            
        }
        
        public ParserService ()
            { 
            
            this.ListTitles = new List<string[]> { };
           
            parser = new ParserWorker<string[]>(new ShopParser());
            parser.Settings = new ShopParserSettings(1,4);
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
            parser.Start();
                        
        }
                
  


    }
}
