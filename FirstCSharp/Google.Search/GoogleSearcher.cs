using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Search
{
    public class GoogleSearcher : SearcherBase, IWebSearcher
    {
        public override void DoSearch(string words)
        {
            _results.Add($"{words} GOOGLE result 1 at http://www.estudiantes.com");
            _results.Add($"{words} GOOGLE result 2 at http://schoolar.google.es");
            _results.Add($"{words} GOOGLE result 3 at htts://www.upeu.edu");            

            _busyTime = 3;
            Thread.Sleep(3000);

        }        
    }
}
