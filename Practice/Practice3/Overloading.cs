using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class Overloading
    {
        public  static void add(int a)
        {
            Console.WriteLine("Sum is " + a);
        }
        public  static void add(int b,int c)
        {
            Console.WriteLine("Sum " + (b + c));
        }
        public static void add(int d,int e,int f)
        {
            Console.WriteLine("Sum " + (d + e + f));
        }

        static void Main(string[] args)
        {
            add(2);
            add(2, 3);
            add(2, 3, 4);
            Console.ReadLine();
        }
    }
}
