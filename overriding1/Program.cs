using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding1
{
    class Sports
    {
        public string getName()
        {
            return "Generic Sports";
        }

        public void getNumberOfTeamMembers()
        {
            Console.WriteLine("Each team has n players in " + getName());
        }
    }
    
    class Soccer : Sports
    {
        public new string getName()
        {
            return "Soccer class";
        }

        public new void getNumberOfTeamMembers()
        {
            Console.WriteLine("Each team has 11 players in " + getName());
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Sports c1 = new Sports();
            Soccer c2 = new Soccer();
            Console.WriteLine(c1.getName());
            c1.getNumberOfTeamMembers();
            Console.WriteLine(c2.getName());
            c2.getNumberOfTeamMembers();

            Console.ReadKey();
        }
    }
}
