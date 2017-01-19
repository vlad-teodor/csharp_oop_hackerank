using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isstanceof
{
    class Student { }
    class Rockstar { }
    class Hacker { }

    class Program
    {
        static string count(LinkedList<object> myList)
        {
            int a = 0, b = 0, c = 0;
            foreach (object element in myList)
            {
                if (element is Student)
                {
                    a++;
                }
                if (element is Rockstar)
                {
                    b++;
                }
                if (element is Hacker)
                {
                    c++;
                }
            }
            return a + " " + b + " " + c;
        }

        static void Main(string[] args)
        {
            LinkedList<object> mylist = new LinkedList<object>();
            int number = int.Parse(Console.ReadLine());
            while (--number >= 0)
            {
                string type = Console.ReadLine(); // next key
                if (type.StartsWith("S") || type.StartsWith("s")) mylist.AddLast(new Student());
                else if (type.StartsWith("R") || type.StartsWith("r")) mylist.AddLast(new Rockstar());
                else if (type.StartsWith("H") || type.StartsWith("h")) mylist.AddLast(new Hacker());
            }
            Console.WriteLine('\n' + count(mylist));
            Console.ReadKey();
        }
    }
}
