using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iShopParser.Core
{
    class ParserWorker<T> where T : class
    {
        iParser<T> parser;

        iParserSettings parserSettings;

        HtmlLoader loader;

        bool isActive;

        #region Proporties
        public iParser <T> Parser
        { 
        get
            { 
            return parser;
            }
        set 
            { 
            parser = value; 
            }
        }
        public iParserSettings Settings
        { 
        get
            { 
            return parserSettings;
            }
        set 
            { 
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }
        public bool IsActive 
        { 
            get 
                { 
                return IsActive;
                }    
            
        }



        #endregion

        public event Action<object,T> OnNewData;
        
        public event Action<object> OnCompleted;
        
        public ParserWorker(iParser<T> parser)
        { 
            this.parser = parser;
        }
        
        public ParserWorker(iParser<T> parser, iParserSettings parserSettings) : this(parser)
        { 
            this.parserSettings = parserSettings;
        }
        
        public void Start()
        { 
            isActive = true;
            Worker();
        } 
        
        public void Stop()
        { 
            
        }
        
        private async void Worker()

        {
            for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
            {
                if (!isActive)
            
                { 
                    OnCompleted?.Invoke(this);
                    return;
                }   
                var source = await loader.GetSourceByCategoryId(i);
                var domParser = new HtmlParser();
                var document = await domParser.ParseAsync(source);

                var result = parser.Parse(document);
                OnNewData?.Invoke(this,result);
            }
            
            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}
