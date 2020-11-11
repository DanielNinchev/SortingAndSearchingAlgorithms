using System;

namespace HeapSort
{
    class Program
    {
        //
        static void HeapSort(int[] array, int n)
        {
            for (int i = n / 2; i >= 0; i--)
            {
                Heapify(array, n, i);
            }
            for (int i = n-1; i >= 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                Heapify(array, i, 0);
            }
        }

        private static void Heapify(int[] array, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && array[left] > array[largest])
            {
                largest = left;
            }

            if (right < n && array[right] > array[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                Heapify(array, n, largest);
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 55, 25, 89, 32, 12, 19, 78, 95, 1, 100 };

            Console.WriteLine(string.Join(" ", array));

            HeapSort(array, 10);

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
