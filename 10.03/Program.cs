using Newtonsoft.Json;
using System;
namespace _10._03
{
    class iPhone
    {
        public string Name { get; set; }
        public string Manufactur { get; set; }
        public string Price { get; set; }
        public DateTime ReleaseD { get; set; }
    }

    class Program
    {
        static void Main()
        {
            iPhone myiPhone = new iPhone();
            myiPhone.Name = "iPhone 15";
            myiPhone.Manufactur = "Apple";
            myiPhone.Price = "1999 $";
            myiPhone.ReleaseD = new DateTime(2023, 03, 13);

            string json = JsonConvert.SerializeObject(myiPhone);
            Console.WriteLine(json);
        }
    }
}
