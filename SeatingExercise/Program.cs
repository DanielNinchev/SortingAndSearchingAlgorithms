using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace SeatingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number N of the occupied seats:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the permutation from 1 to N:");
            int[] seats = new int[n];

            List<int> occupiedSeats = new List<int>();
            int occupiedSeat = 0;

            for (int i = 0; i < seats.Length; i++)
            {
                seats[i] = int.Parse(Console.ReadLine());

                if (seats[i] > n || seats[i] <= 0)
                {
                    throw new ArgumentException("Error! The number of the occupied seat cannot be smaller than 1 or larger than N.");
                }

                occupiedSeat = seats[i];

                if (occupiedSeats.Contains(occupiedSeat))
                {
                    throw new ArgumentException("Error! Multiple people cannot occupy one seat at the same time.");
                }

                occupiedSeats.Add(occupiedSeat);
            }

            Console.WriteLine();

            int counter = 0;

            for (int i = 0; i < seats.Length; i++)
            {
                for (int j = 0; j < seats.Length - 1; j++)
                {
                    if (seats[j] > seats[j + 1])
                    {
                        int temp = seats[j];
                        seats[j] = seats[j + 1];
                        seats[j + 1] = temp;

                        counter++;
                    }
                }
            }

            Console.WriteLine($"The number of needed swaps is: {counter}.");
        }
    }
}
