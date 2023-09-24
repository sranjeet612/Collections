using System.Collections;
namespace Collections
{
    class StackDemo
    {
        public static void Main()
        { 

            // insert data into stack 
            Stack stack = new Stack();
            stack.Push(100);
            stack.Push("Ranjeet");
            stack.Push(3.14);


            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

         //   Console.WriteLine($" stack value {stack.Pop()}");
              Console.WriteLine($" stack value {stack.Peek()}");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
