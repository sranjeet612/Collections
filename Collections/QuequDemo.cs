using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Collections
{
    class QuequDemo
    {
        public static void Main()
        {
            Queue<string> obj = new Queue<string>();

            obj.Enqueue(".Net");
            obj.Enqueue("Azure");
            obj.Enqueue("MVC");

            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }

            string s = obj.Peek();
            Console.WriteLine(s);

            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
