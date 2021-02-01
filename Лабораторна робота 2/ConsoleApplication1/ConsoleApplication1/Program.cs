using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of yhe array");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            MyArray test = new MyArray(n);
            test.Max_and_Min();
            test.Sum();
            test.Average_Value();
            test.Odd_Items();
            Console.ReadLine();
        }
    }
}
