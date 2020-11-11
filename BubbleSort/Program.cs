using System;

namespace BubbleMethod //прост сортиращ алгоритъм
{
    class Program
    {
        //Не е добре да се използва за големи множества от данни. Подходящ за малки множества. Квадратична сложност.
        static void Main(string[] args)
        {
            int[] array = new int[] { 6, 9, 4, 3, 5, 1, 42, -2 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp; 
                    }
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
