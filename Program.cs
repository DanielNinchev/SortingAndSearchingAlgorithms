using System;
using System.Globalization;

namespace ShellSort
{
    class Program
    {
        //сложен алгоритъм за сортиране
        static void Main(string[] args)
        {
            int[] array = new int[] { 46, 60, 56, 81, 16 };

            for (int gap = array.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    int value = array[i];
                    int j;

                    for (j = i; j >= gap && array[j-gap] > value; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }

                    array[j] = value;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
