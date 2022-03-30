using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = getNewSquareArray(20);
            int[] maximumValues = getMaximumValue(array,20);
            for (int i = 0; i < maximumValues.Length; i++)
                Console.Write(maximumValues[i]+"\t");
            Console.WriteLine();
        }
        static int[,] getNewSquareArray(int arrayLength)
        {
            Random rn = new Random();
            int[,] returnArray = new int[arrayLength,arrayLength];
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    returnArray[i,j] = rn.Next(-10, 10);
                    Console.Write(returnArray[i,j]+"\t");
                }
                Console.WriteLine();
            }
                    

            return returnArray;
        }
        static int[] getMaximumValue(int[,] array,int arrayLength)
        {
            Console.WriteLine("\n\nПолученный массив ");
            int[] localMaximums;
            int maximumCount = 0;
            for (int i = 0; i < arrayLength; i++)
                for (int j = 1; j < arrayLength - 1; j++)
                    if (array[i,j-1] <= array[i,j] || array[i,j + 1] <= array[i,j])
                    maximumCount++;
            localMaximums = new int[maximumCount];
            int currentMaximumIndex = 0;
            for (int i = 0; i < arrayLength; i++)
                for (int j = 1; j < arrayLength - 1; j++)
                    if (array[i, j - 1] <= array[i, j] || array[i, j + 1] <= array[i, j])
                    {
                        localMaximums[currentMaximumIndex] = array[i,j];
                        currentMaximumIndex++;
                    }
            return localMaximums;
        }
    }
}
