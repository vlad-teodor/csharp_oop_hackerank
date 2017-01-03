using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    class MyCalculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += (n % i == 0) ? i : 0;
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyCalculator myCalculator = new MyCalculator();
            Console.Write("I implemented: ");
            implementedInterfaceNames(myCalculator);
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myCalculator.divisorSum(n));

            Console.ReadKey();
        }
        
        static void implementedInterfaceNames (object o)
        {
            foreach (Type interfacei in o.GetType().GetInterfaces())
            {
                Console.WriteLine(interfacei.ToString());
            }
        }
    }
}
