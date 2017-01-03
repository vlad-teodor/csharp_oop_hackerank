using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance1
{
    class Animal
    {
        public void walk()
        {
            Console.WriteLine("I am walking");
        }
    }

    class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("I am flying");
        }

        public void sing()
        {
            Console.WriteLine("I am singing");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            bird.walk();
            bird.fly();
            bird.sing();

            Console.ReadKey(); // sa nu se inchida consola instant
        }
    }
}
