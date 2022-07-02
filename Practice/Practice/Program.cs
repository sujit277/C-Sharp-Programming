using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Practice
{
    //Accessing Access Modifiers
    public class Program
    {
        public void show1()
        {
            Console.WriteLine("Given Method is a Public Method");
        }
        private void show2()
        {
            Console.WriteLine("Given Method is a Private Method");
        }
        protected void show3()
        {
            Console.WriteLine("Given Method is a Protected Method");
        }
        internal void show4()
        {
            Console.WriteLine("Given Method is a Internal Method");
        }
        protected internal void show5()
        {
            Console.WriteLine("Given Method is a Protected Internal Method");
        }
        private protected void show6()
        {
            Console.WriteLine("Given Method is a Private Protected Method");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.show1();
            p1.show2();
            p1.show3();
            p1.show4();
            p1.show5();
            p1.show6();
            Console.ReadLine();
        }
    } 
}
