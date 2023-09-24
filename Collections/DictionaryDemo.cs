using System.Collections;

namespace Collections
{
    class DictionaryDemo
    {
        public static void Main()
        {

            Dictionary<string, string> obj = new Dictionary<string, string>();
            obj.Add("Technology", "Azure");

            Dictionary<string, string> ds = new Dictionary<string, string>() {
                { "Technology", "Azure"},
                { "Course", "MVC"},
                { "Fee", "2000"},
                { "Duration", "2 month"}
            };

            foreach (var item in ds.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(ds["Course"]);


            Dictionary<string, Employee> emp = new Dictionary<string, Employee>();
            emp.Add("Ranjeet", new Employee() { ID = 10, Name = "Ranjeet", Email = "wteyurr", Address = "HYD" });


            Employee data = emp["Ranjeet"];

            Console.WriteLine(data.ID);
            Console.WriteLine(data.Name);
            Console.WriteLine(data.Email);
            Console.WriteLine(data.Address);


            Console.ReadLine();
        }
    }
}
