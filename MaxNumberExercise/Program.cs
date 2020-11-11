using System;
using System.Text;

namespace MaxNumberExercise
{
    class Program
    {
        static void Sort(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length - 1; j++)
                {
                    if (str[j].CompareTo(str[j + 1]) < 0)
                    {
                        string left = str[j];
                        string right = str[j + 1];

                        //Тук се подсигурявам, че 889 ще бъде по-напред от 8.
                        if (str[j].Length < str[j+1].Length && left[0] == right[0])
                        {
                            char bestCharLeft = '0';
                            char bestCharRight = '0';

                            foreach (var ch in left)
                            {
                                if (ch > bestCharLeft)
                                {
                                    bestCharLeft = ch;
                                }
                            }

                            foreach (var ch in right)
                            {
                                if (ch > bestCharRight)
                                {
                                    bestCharRight = ch;
                                }
                            }

                            if (bestCharLeft >= bestCharRight)
                            {
                                continue;
                            }
                            else
                            {
                                string temp = str[j];
                                str[j] = str[j + 1];
                                str[j + 1] = temp;
                            }

                        }
                        else
                        {
                            string temp = str[j];
                            str[j] = str[j + 1];
                            str[j + 1] = temp;
                        }
                    }
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the bills:");

            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 100)
            {
                throw new ArgumentException("Error! N must be in the interval [1 ; 100]!");
            }

            int[] bills = new int[n];
            StringBuilder s = new StringBuilder();

            for (int i = 0; i < bills.Length; i++)
            {
                bills[i] = int.Parse(Console.ReadLine());

                if (bills[i] >= 1 && bills[i] <= 1000000)
                {
                    s.Append(bills[i] + " ");
                }

                else
                {
                    throw new ArgumentException("Error! The numbers must be in the interval [1 ; 1 000 000]!");
                }
                
            }

            Console.WriteLine();

            string concatinatedNumbers = s.ToString();
            string[] numbers = concatinatedNumbers.Split(" ");

            Sort(numbers);
        }
    }
}
