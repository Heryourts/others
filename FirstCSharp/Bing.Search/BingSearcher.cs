using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Search
{
    public class BingSearcher : SearcherBase, IWebSearcher
    {
        public override void DoSearch(string words)
        {
            _results.Add($"{words} BING result 1 at http://www.estudiantes.com");
            _results.Add($"{words} BING result 2 at http://schoolar.google.es");
            _results.Add($"{words} BING result 3 at htts://www.upeu.edu");

            _busyTime = 2;
            Thread.Sleep(2000);
        }
    }
}
