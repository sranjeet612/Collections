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
            Queue<string> queue = new Queue<string>();

            queue.Enqueue(".Net");
            queue.Enqueue("Azure");
            queue.Enqueue("MVC");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            string s = queue.Peek();
            Console.WriteLine(s);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
