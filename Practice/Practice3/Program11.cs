using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class Program11
    {
        private int num;
        public int Num 
        { 
            get { return num; } 
            set 
            {
                if (value > 23)
                {
                    num = value;
                }
            } 
        }

        //Accessing everywhere using public keyword
        //public string name;
        public static void Main(string[] args)
        {
            Program11 p = new Program11();
            int val = Convert.ToInt32(Console.ReadLine());
            p.Num = val;
            Console.WriteLine(p.num);
            Console.WriteLine("Value after Assigning");
            Console.WriteLine(p.Num);

            //p.name = "Sujit";
            //Console.WriteLine(p.name);
            Console.ReadLine();
        }
    }
}
