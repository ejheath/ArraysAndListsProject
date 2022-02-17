using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var evens = new List<int>();
            var odds = new List<int>();

           
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach (var number in evens)
            { 
                Console.WriteLine($"{number} is an even number");

            }
            foreach (var number in odds)
            {

                Console.WriteLine($"{number} is an odd number");
            }

        }   
    }


}
