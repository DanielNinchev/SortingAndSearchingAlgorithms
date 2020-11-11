using System;
using System.Net;

namespace ComSort
{
    class Program
    {
        //Подобрен метод на мехурчето. Предимството му е, че gap-ът се изчислява със стесняващ фактор = 1.3 (намерен експериментално).
        static void Sort(int[] arr)
        {
            int gap = arr.Length;

            bool swapped = false;

            do
            {
                swapped = false;

                gap = newGap(gap);

                
                for (int i = 0; i < arr.Length - gap; i++)
                {
                    if (arr[i] > arr[i+gap])
                    {
                        swapped = true;
                        int temp = arr[i];
                        arr[i] = arr[i + gap];
                        arr[i + gap] = temp;
                    }
                }

            } while (gap > 1 || swapped);
        }

        private static int newGap(int gap)
        {
            gap = (int)(gap / 1.3);

            if (gap == 9 || gap == 10)
            {
                gap = 11;
            }

            if (gap < 1)
            {
                return 1;
            }

            return gap;
        }

        static void Main(string[] args)
        {
            int[] arr = { 123, 212, 12, 46, 54, 21, 1, 78, 136136, -89, 0, 11521, 301, -4 };

            Console.WriteLine(string.Join(" ", arr));

            Sort(arr);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
