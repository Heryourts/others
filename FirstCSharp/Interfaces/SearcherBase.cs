using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class SearcherBase
    {
        #region properties

        protected List<string> _results;
        protected int _busyTime;

        public List<string> Results => _results;

        public int BusyTime => _busyTime;

        #endregion

        #region constructor
        public SearcherBase()
        {
            _results = new List<string>();
            _busyTime = 0;
        }

        public abstract void DoSearch(string words);

        #endregion


        public async Task DoSearchAsync(string words)
        {
            await Task.Run(() => {
                DoSearch(words);
            });
        }



    }
}
