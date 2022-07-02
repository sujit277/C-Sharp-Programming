using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public interface Animal
    {
        void Sound();
    }

    public class Dog : Animal
    {
        public void Sound()
        {
            Console.WriteLine("Dog is Barking");
        }
    }
    public class Interface
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.Sound();
            Console.ReadLine();
        }
    }
}
