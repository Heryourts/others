using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahoo.Search
{
    public class YahooSearcher : SearcherBase, IWebSearcher
    {  
        public override void DoSearch(string words)
        {
            _results.Add($"{words} YAHOO result 1 at http://www.estudiantes.com");
            _results.Add($"{words} YAHOO result 2 at http://schoolar.google.es");
            _results.Add($"{words} YAHOO result 3 at htts://www.upeu.edu");

            _busyTime = 4;
            Thread.Sleep(4000);
        }        
    }
}
