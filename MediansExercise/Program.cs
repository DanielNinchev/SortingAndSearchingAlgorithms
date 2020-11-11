using System;
using System.Collections.Immutable;

namespace MediansExercise
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students that had the test:");

            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 10000)
            {
                throw new ArgumentException("Error! N cannot be smaller than 1 or larger than 10 000.");
            }

            double[] array = new double[n];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(30000) + 1;
            }

            Console.WriteLine("The grades of the students are:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            Array.Sort(array);

            Console.WriteLine("The sorted grades of the students are:");

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            int counter = 0;
            double med = 0.0;

            Console.WriteLine("The medians are:");

            for (double i = 0; i < array.Length; i++)
            {
                counter++;
                if (counter % 2 == 0)
                {
                    med = (array[counter / 2] + array[(counter / 2) - 1]) / 2;
                }
                else
                {
                    med = array[(counter / 2) + (1/2)];
                }

                Console.Write($"{med} ");
            }

            Console.WriteLine();
        }
    }
}
