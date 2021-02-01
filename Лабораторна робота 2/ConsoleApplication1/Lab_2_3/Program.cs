using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.Set_to_store("car", 0);
            store.Set_to_store("bus", "buses", 23.4, 1);
            Console.WriteLine(store[1].Print());
            Console.WriteLine(store["bus"]);
            store.Print_All();
            Console.ReadLine();
        }
    }
}
