using System;
using System.Linq;
using Newtonsoft.Json;
using OrderLibrary_EF.Models;

namespace OrderLibrary_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Database();
            db.Add(new Order() { ItemName = "XLX", Custom = "DZY", Balance = 10 });
            db.SaveChanges();


            var obj = db.Orders.First();
            //var rand = new Random();
            //var obj = db.Orders.OrderBy( s => rand.Next()).First();
            var str = JsonConvert.SerializeObject(obj, Formatting.Indented);
            Console.WriteLine(str);
        }
    }
}