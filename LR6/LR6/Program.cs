using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rn = new Random();

            Console.WriteLine("Please enter array length:");

            int length = Convert.ToInt32(Console.ReadLine()), 
                count = 0, 
                maxValue = 10, 
                minValue = maxValue;
            int[] array = new int[length],oddArray;

            Console.WriteLine("Old array = ");

            for (int i = 0; i < length; i++)
            {
                array[i] = rn.Next(-10, maxValue);
                Console.Write(array[i]+"\t");
                if (array[i] % 2 != 0) count++;
            }

            oddArray = new int[count];

            Console.WriteLine("New array with odd values = ");

            for (int i = 0; i < length; i++)
                if (array[i] % 2 != 0) { 
                    oddArray[i] = array[i];
                    Console.Write(oddArray[i]+"\t");
                    if (oddArray[i] > minValue) minValue = oddArray[i];
                }

            Console.WriteLine("Min odd value = " + minValue);
        }
    }
}
