using System.Collections;
namespace Collections
{
    class Program
    {

        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            Console.WriteLine($"Intial Capacity {al.Capacity}");

            al.Add(100);

            Console.WriteLine($"Capacity after adding 1 element {al.Capacity}");

            al.Add(3.14);
            al.Add("Ranjeet");
            al.Add(true);

            Console.WriteLine($"Capacity after adding 4 element {al.Capacity}");

            al.Add("Test");

            Console.WriteLine($"Capacity after adding 5 element {al.Capacity}");


            for (int i = 0; i < al.Count; i++)
            {
                object o = al[i];

                int j = (int)o;

                Console.WriteLine($"array List elements: {j}");
            }

            Console.ReadLine();
        }
    }
}