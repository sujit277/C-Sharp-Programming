using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class A
    {
        public virtual void show()
        {
            Console.WriteLine("Show Method of class A");
        }
    }
    public class B:A
    {
        public override void show()
        {
            Console.WriteLine("Show Method of class B");
        }
    }
    public class Overiding
    {
        static void Main(string[] args)
        {
            A a = new A();
            A b = new B();
            a.show();
            b.show();
            Console.ReadLine();
        }
  
    }
}
