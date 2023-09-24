using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ArrayListDemo
    {
        public static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(true);
            arrayList.Add(1.34);
            arrayList.Add("ArrayList");

            if (arrayList.Contains("ArrayList"))
            {
                Console.WriteLine("ArrayList");
            }

            foreach (var item in arrayList)
            {
                Console.WriteLine($"Before removing {item}");
            }


            arrayList.RemoveAt(1);

            foreach (var item in arrayList)
            {
                Console.WriteLine($"After removing {item}");
            }

            int index = arrayList.IndexOf(1.34);

            Console.WriteLine($"index: {index}");

            arrayList.Insert(0, "Ranjeet");

            foreach (var item in arrayList)
            {
                Console.WriteLine($"After Adding  {item}");
            }
            Console.ReadLine();
        }

    }
}
