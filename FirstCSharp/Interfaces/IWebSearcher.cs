using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IWebSearcher
    {
        List<string> Results { get; }                
        int BusyTime { get; }
        void DoSearch(string words);

        Task DoSearchAsync(string words);

    }
}
