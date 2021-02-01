using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyArray
    {
        private int[] array;
        private int length;

        public MyArray(int length)
        {
            this.length = length;
            Random ran = new Random();
            array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = ran.Next(1,20);
                Console.Write("{0}  ", array[i]);
            }
            Console.WriteLine();
        }
        
        public int this[int index]
        {
            set
            {
                array[index] = value;
            }
            get
            {
                return array[index];
            }
        }

        public void Max_and_Min()
        {
            int max=array[0], min=max;
            for (int i = 1; i < length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine("max num is : {0}, min num is : {1}", max, min);
        }

        public void Sum()
        {
            int sum=0;
            foreach (int value in array)
                sum += value;
            Console.WriteLine("Sum of the elements in the array is: {0}", sum);

        }

        public void Average_Value()
        {
            double sum = 0;
            foreach (int value in array)
                sum += value;
            double average = sum / length;
            Console.WriteLine("The average is: {0}", average);
        }

        public void Odd_Items()
        {
            Console.WriteLine("All odd items in the array are: ");
            foreach (int value in array)
                if (value % 2 != 0)
                    Console.Write("{0}  ", value);
        }


    }
}
