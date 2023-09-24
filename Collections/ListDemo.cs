namespace Collections
{
    class ListDemo
    {
        public static void Main()
        {

            List<string> list = new List<string>();
            list.Add("Azure");
            list.Add("Angular");
            list.Add(".Net Core");
            list.Add("MVC");
            list.Add(".Net Core");
            list.Add("MVC");

           
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(list.FirstOrDefault(x => x.Equals(".Net Core")));

            Console.ReadLine();
        }
    }
}
