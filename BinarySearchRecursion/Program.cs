using System;

namespace BinarySearchRecursion
{
    class Program
    {
        static int BinarySearch(int[] arr, int x, int left, int right)
        {
            if (right >=  1)
            {
                int m = left + (right - left) / 2;

                if (arr[m] == x)
                {
                    return m;
                }
                else if (arr[m] > x)
                {
                    return BinarySearch(arr, x, left, m - 1);
                }
                else
                {
                    return BinarySearch(arr, x, m + 1, right);
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
