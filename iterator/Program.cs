using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator
{
    class Iterator
    {
        object[] list;
        int position = 0;
        public Iterator(object[] list)
        {
            this.list = list;
        }
        public bool hasNext()
        {
            return position < list.Length; // false cand e mai mare decat dimensiunea
        }
        public object getNext()
        {
            return list[position++]; // intoarce elementul de pe ultima pozitie si incrementeaza pozitia
        }
    }

    class Program
    {
        static Iterator func(object[] list)
        {
            Iterator it = new Iterator(list);
            while (it.hasNext())
            {
                if (it.getNext() is string)
                {
                    break;
                }
            }
            return it;
        }
        static void Main(string[] args)
        {
            object[] list = { 42, 10, "###", "Hello", "C#" };
            Iterator it = func(list);
            while (it.hasNext())
            {
                Console.WriteLine(it.getNext());
            }
            Console.ReadKey();
        }
    }
}
