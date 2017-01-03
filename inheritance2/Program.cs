using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance2
{
    class Arithmetic
    {
        public int add(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    class Adder : Arithmetic
    {
        public void printSuperclass()
        {
            Console.WriteLine("My superclass is: " + this.GetType().BaseType.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Adder adder = new Adder();

            adder.printSuperclass();
            Console.WriteLine(adder.add(30, 12) + " " + adder.add(10, 3) + " " + adder.add(30, -10));

            Console.ReadKey();
        }
    }
}
