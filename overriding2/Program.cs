using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding2
{
    class BiCycle
    {
        protected string defineMe()
        {
            return "a vehicle with pedals.";
        }
    }

    class MotorCycle : BiCycle
    {
        string defineMe()
        {
            return "a cycle with an engine";
        }
        
        public MotorCycle()
        {
            Console.WriteLine("Hello I am motorcycle, I am " + defineMe());
            string temp = base.defineMe();
            Console.WriteLine("My ancestor is a cycle who is " + temp);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MotorCycle M = new MotorCycle();

            Console.ReadKey();
        }
    }
}
