using System.Collections;

namespace Collections
{
    class HashDemo
    {
        static void Main(string[] args)
        {

           Hashtable hashtable = new Hashtable();

            hashtable.Add(1, ".Net Core");
            hashtable.Add("Technology", "Azure");
            hashtable.Add(2, 100);
            hashtable.Add(3, true);

            foreach (var ht in hashtable.Values)
            {
                Console.WriteLine(ht);
            }

            var data =hashtable["Technology"];

            Console.WriteLine(data);

            Console.ReadLine();
        }
    }
}
