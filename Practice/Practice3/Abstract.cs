using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public abstract class Tiger
    {
        public abstract void show();
        public void sleep()
        {
            Console.WriteLine("Tiger is Sleeping");
        }
    }
    public class WhiteTiger : Tiger
    {
        public override void show()
        {
            Console.WriteLine("WhiteTiger is Shown");
        }
    }
    public class Abstract
    {
        static void Main(string[] args)
        {
            WhiteTiger wt = new WhiteTiger();
            wt.show();
            Console.ReadLine();
        }
    }
}
