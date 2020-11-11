using System;

namespace MergeSort
{
    class Program
    {
        //Сложен алгоритъм. Добро представяне при списъци с големи мащаби. Недостатък - ще използва много памет.

        static int[] Splits(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }

            int middle = array.Length / 2;

            int[] leftArray = new int[middle];
            int[] rightArray = new int[array.Length - middle];

            for (int i = 0; i < middle; i++)
            {
                leftArray[i] = array[i];
            }

            for (int i = middle, j=0; i < array.Length; i++, j++) 
            {
                rightArray[j] = array[i];
            }

            leftArray = Splits(leftArray);
            rightArray = Splits(rightArray);

            return Merge(leftArray, rightArray);
        }

        private static int[] Merge(int[] leftArray, int[] rightArray)
        {
            int leftIncrease = 0;
            int rightIncrease = 0;

            int[] array = new int[leftArray.Length + rightArray.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (rightIncrease == rightArray.Length || ((leftIncrease < leftArray.Length) && (leftArray[leftIncrease] <= rightArray[rightIncrease])))
                {
                    array[i] = leftArray[leftIncrease];
                    leftIncrease++;
                }
                else if (leftIncrease == leftArray.Length || ((rightIncrease < rightArray.Length) && (leftArray[leftIncrease] >= rightArray[rightIncrease])))
                {
                    array[i] = rightArray[rightIncrease];
                    rightIncrease++;
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 6, 5, 3, 1, 8, 7, 2, 4 };

            Console.WriteLine(string.Join(" ", nums));

            nums = Splits(nums);

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
