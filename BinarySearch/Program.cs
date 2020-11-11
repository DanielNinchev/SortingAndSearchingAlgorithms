using System;

namespace BinarySearch
{
    //метод на двоично търсене. Подходящо е за големи множества от елементи. Tрябва масивът да е сортиран предварително;
    class Program
    {
        static int BinarySearch(int[] array, int value, int left, int right)
        {
            if (right < left)
            {
                return -1;
            }

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (array[middle] == value)
                {
                    return middle;
                }
                else if (array[middle] < value)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 46, 61, 94, 810, 1016 };

            int result = BinarySearch(array, 0, 0, array.Length - 1);

            Console.WriteLine(result);
        }
    }
}
