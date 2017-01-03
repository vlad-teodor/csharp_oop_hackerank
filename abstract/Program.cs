using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    abstract class Book
    {
        protected string title;
        public abstract void setTitle(string s);
        public string getTitle()
        {
            return title;
        }
    }

    class MyBook : Book
    {
        public override void setTitle(string s)
        {
            title = s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            MyBook newNovel = new MyBook();
            newNovel.setTitle(title);
            Console.WriteLine("The title is: " + newNovel.getTitle());

            Console.ReadKey();
        }
    }
}
