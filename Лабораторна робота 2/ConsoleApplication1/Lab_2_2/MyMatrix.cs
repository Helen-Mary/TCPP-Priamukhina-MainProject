using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2
{
    class MyMatrix
    {
        private int N { get; set;}
        private int M { get; set;}
        int[,] array;

        public MyMatrix(int n, int m)
        {
            this.N = n;
            this.M = m;
            
        }

        public int this[int i, int j]
        {
            set
            {
                array[i, j] = value;
            }
            get
            {
                return array[i, j];
            }
        }

        public void Fill_the_Array()
        {
            array = new int[N, M];
            Random ran = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    array[i, j] = ran.Next(1, 20);
                    Console.Write("{0}  ", array[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void Change(int n, int m)
        {

            this.M = m;
            this.N = n;
        }

        public void Index(int left_i, int left_j, int right_i, int right_j)
        {
            for (int i = left_i; i <= right_i; i++)
            {
                for (int j = left_j; j <= right_j; j++)
                {
                    Console.Write("{0}  ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
