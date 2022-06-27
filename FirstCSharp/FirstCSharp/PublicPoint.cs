using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp
{
    public class Point
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }


        internal void SetX(int x)
        {
            X = x;
        }
    }

    public class DerivedPoint : Point
    {
        public DerivedPoint()
        {
            var myx = X;
            X = 100;
        }
    
    }


    public class AnotherPoint
    {
        private Point _point;

        public AnotherPoint()
        {
            _point = new Point();
            //_point.X = 100;
            _point.SetX(100);

        }
        
    }






}
