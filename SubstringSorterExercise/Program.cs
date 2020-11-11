using System;
using System.Collections.Generic;
using System.Text;

namespace SubstringSorterExercise
{
    class Program
    {
        static int l;
        static void Sort(string s)
        {
            StringBuilder text = new StringBuilder(s.Length);

            for (int i = 0; i < s.Length; i++)
            {
                text.Append(s[i]);
            }

            int gap = text.Length;

            bool swapped = false;

            do
            {
                swapped = false;

                gap = newGap(gap);


                for (int i = 0; i < l - gap; i++)
                {
                    if (text[i] > text[i + gap])
                    {
                        swapped = true;
                        char temp = text[i];
                        text[i] = text[i + gap];
                        text[i + gap] = temp;
                    }
                }

            } while (gap > 1 || swapped);

            s = text.ToString();
            Console.WriteLine($"The lexicographically smallest result of the sorted string according to the device power is: {s}.");
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
            Console.WriteLine("Enter the power of the device L in the interval [2;50]:");
            l = int.Parse(Console.ReadLine());

            if (l < 2 || l > 50)
            {
                throw new ArgumentException("Error! L should be in the interval [2;50].");
            }

            Console.WriteLine("Enter the text:");
            string s = Console.ReadLine().ToUpper();

            int n = s.Length;

            if (n < l || n > 50 || n < 2)
            {
                throw new ArgumentException("Error! The string cannot be shorter than 2 characters, shorter than the power of the device or longer than 50 characters.");
            }

            List<char> allowedSymbols = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < s.Length; i++)
            {
                if (!allowedSymbols.Contains(s[i]))
                {
                    throw new ArgumentException("Error! The string can contain only capital letters from A to Z.");
                }
            }

            Sort(s);    
        }
    }
}
