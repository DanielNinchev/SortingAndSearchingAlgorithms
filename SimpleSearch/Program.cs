using System;

namespace SimpleSearch
{
    // не е подходящо за големи множества от елементи;
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 46, 11, 23, 8, 17, 4, 6 };

            bool result = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 4)
                {
                    result = true;
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
