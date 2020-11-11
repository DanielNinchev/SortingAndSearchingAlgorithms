using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Xml.XPath;

namespace TrosverExercise
{
    class Program
    {
        static int n;
        static int bestNum;
        static int[] numbers2;
        static List<int> listOfNumbers = new List<int>();

        static void Search(int[] arr)
        {
            for (int i = 1; i <= bestNum; i++)
            {
                int counter = 0;

                foreach (var number in arr)
                {
                    if (number >= i)
                    {
                        counter++;
                    }
                }

                if (counter != 0)
                {
                    listOfNumbers.Add(counter);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of numbers in Stancho's list:");
            n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            bestNum = int.MinValue;

            Console.WriteLine("Stancho's numbers are: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > bestNum)
                {
                    bestNum = numbers[i];
                }

                Console.Write(numbers[i] + ", ");
            }

            Console.WriteLine();

            Search(numbers);

            Console.WriteLine("Eli's numbers are:");
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                Console.Write(listOfNumbers[i] + ", ");
            }

            numbers2 = new int[listOfNumbers.Count];

            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = listOfNumbers[i];
            }

            Console.WriteLine();

            listOfNumbers = new List<int>();

            Search(numbers2);

            Console.WriteLine("Krisi's numbers are:");
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                Console.Write(listOfNumbers[i] + ", ");
            }
        }
    }
}
