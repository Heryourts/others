using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp
{
    public abstract class AbstractClass
    {
        public abstract string DoWork();

        public void SayHello(string name)
        {

            Console.WriteLine("Hello " + name + ", you are working at the "+DoWork());
        }
    }


    public class NonAbstract : AbstractClass
    {
        public override string DoWork()
        {
            return "IATec Trainee Academy";
        }
    }

}
