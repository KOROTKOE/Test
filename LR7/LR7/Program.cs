using System;

namespace LR7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the array separated by commas, at the end of the array, click Enter.");
            string startStringValue = Console.ReadLine();
            //Получение значений как числовой массив
            int[] numberArray = getNumberArray(startStringValue);

            //Нахождение минимального значения в массиве
            int minValueIndex = getMinValueIndex(numberArray);
            Console.WriteLine("\n\nMin value index in array is " + minValueIndex);

            //Вычисление суммы элементов между первых 2 отрицательных значений
            int sumBeetweenOddValues = getSumBetweenOddValues(numberArray);
            Console.WriteLine("\n\nSum beetween first odd values in the array is " + sumBeetweenOddValues);

            //Преобразование массива по условию
            int[] convertingArray = getConvertingArray(numberArray);
            Console.WriteLine("\n\nConverting array is:");
            for (int i = 0; i < convertingArray.Length; i++)
                Console.Write(convertingArray[i]+"\t");
            Console.WriteLine();
        }
        static int[] getNumberArray(string futureArray)
        {
            string[] numberArrayInStringFormat = futureArray.Split(',');
            int[] numberArray = new int[numberArrayInStringFormat.Length];
            for (int i = 0; i < numberArray.Length; i++)
                numberArray[i] = int.Parse(numberArrayInStringFormat[i]);
            return numberArray;
        }
        public static int getMinValueIndex(int[] array)
        {
            int minValue = int.MaxValue, minValueIndex = 0;
            for (int i = 0; i < array.Length; i++)
                if (minValue > array[i])
                {
                    minValue = array[i];
                    minValueIndex = i;
                }
            return minValueIndex;
        }
        static int getSumBetweenOddValues(int[] array)
        {
            int sumBeetweenOddValues = 0, firstOddValueIndex = -1, secondOddValueIndex = 0;
            for (int i = 0; i < array.Length; i++)
                //Поиск первых 2 отрицательных элементов
                if (array[i] < 0)
                    if (firstOddValueIndex < 0)
                        firstOddValueIndex = i;
                    else secondOddValueIndex = i;

            if (firstOddValueIndex < 0) firstOddValueIndex = 0;
            else firstOddValueIndex++;
            if (secondOddValueIndex == 0) secondOddValueIndex = array.Length - 1;
            //Вычисление суммы
            for (int i = firstOddValueIndex; i < secondOddValueIndex; i++)
                sumBeetweenOddValues += array[i];
            return sumBeetweenOddValues;
        }
        static int[] getConvertingArray(int[] array)
        {
            int[] convertingArray = new int[array.Length];
            int countValue = 0;
            //Получение элементов массива по модулю не более 1
            for (int i = 0; i < array.Length; i++)
                if (Math.Abs(array[i]) <= 1)
                {
                    convertingArray[countValue] = array[i];
                    countValue++;
                }

            for (int i = 0; i < array.Length; i++)
                if (Math.Abs(array[i]) > 1)
                {
                    convertingArray[countValue] = array[i];
                    countValue++;
                }
            return convertingArray;
        }
    }
}
