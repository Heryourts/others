using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalProject
{
    /// <summary>
    /// class 
    /// </summary>
    public class MyThink
    {
        public int ThinkId { get; set; }
        public string ThinkName { get; set; }
    }

    public class PublicMyThink
    {
        private readonly List<MyThink> _mythinks;
               
        public PublicMyThink()
        {
            _mythinks = new List<MyThink>();
        }


        /// <summary>
        /// add think
        /// </summary>
        /// <param name="myThink"></param>
        public void AddThink(MyThink myThink)
        {
            _mythinks.Add(myThink);
        }

        /// <summary>
        /// return pairs
        /// </summary>
        /// <returns></returns>
        public List<MyThink> GetPairs()
        {
            List<MyThink> tempThinks = new List<MyThink>();
            for (int i = 0; i < _mythinks.Count; i++)
            {
                if( (i+1) % 2 == 0)
                    tempThinks.Add(_mythinks[i]);
            }
            return tempThinks;
        }

        /// <summary>
        /// Return not pairs
        /// </summary>
        /// <returns></returns>
        internal List<MyThink> GetNotPairs()
        { 
            return _mythinks;
        }
    }

}
