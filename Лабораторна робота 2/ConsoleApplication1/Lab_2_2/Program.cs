using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n and m");
            string temp = Console.ReadLine();
            int n = int.Parse(temp);
            temp = Console.ReadLine();
            int m = int.Parse(temp);
            MyMatrix matrix = new MyMatrix(n,m);

            Console.WriteLine("0-Exit");
            Console.WriteLine("1-Fill the array");
            Console.WriteLine("2-Change");
            Console.WriteLine("3-Show");
            string s =Console.ReadLine();
            int chose = int.Parse(s);
            Console.WriteLine();
            while (chose != 0)
            {
                switch(chose)
                {
                    case 1: { matrix.Fill_the_Array(); break; }
                    case 2:
                        {
                            Console.WriteLine("enter new n and m");
                            temp = Console.ReadLine();
                            n = int.Parse(temp);
                            temp = Console.ReadLine();
                            m = int.Parse(temp);
                            matrix.Change(n, m);
                            break;
                        }
                    case 3:
                        {
                            Link:
                            try
                            {
                                Console.WriteLine("enter left corner n and m, right corner n and m ");
                                temp = Console.ReadLine();
                                n = int.Parse(temp);
                                temp = Console.ReadLine();
                                m = int.Parse(temp);
                                temp = Console.ReadLine();
                                int i = int.Parse(temp);
                                temp = Console.ReadLine();
                                int j = int.Parse(temp);
                                matrix.Index(n, m, i, j);
                                break;
                            }
                            catch (NullReferenceException)
                            {
                                Console.WriteLine("There was not array, we fill it automatecaly");
                                matrix.Fill_the_Array();
                                goto Link;
                            }
                        }
                }

                Console.WriteLine("0-Exit");
                Console.WriteLine("1-Fill the array");
                Console.WriteLine("2-Change");
                Console.WriteLine("3-Show");
                s = Console.ReadLine();
                chose = int.Parse(s);
                Console.WriteLine();
            }
        }
    }
}
