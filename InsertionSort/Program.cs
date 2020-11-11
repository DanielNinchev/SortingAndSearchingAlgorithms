using System;

namespace InsertionSort //прост алгоритъм, добър за сортиране на малки групи от данни;
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 46, 60, 56, 81, 16 };

            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];

                int index = i;

                while (index > 0 && array[index-1] >= value)
                {
                    array[index] = array[index - 1];
                    index--;
                }

                array[index] = value;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
