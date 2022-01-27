using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numberRange = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach(var number in numberRange)
            {
                if(number%2==0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Hello. I'm a number machine. I'm here to send you some numbers.");
            Console.WriteLine("First up we have some odd numbers. Now printing...");
            foreach(var oddNumber in odds)
            {
                Console.WriteLine(oddNumber);
            }
            Console.WriteLine("Next, we have some even numbers. Now printing...");
            foreach(var evenNumber in evens)
            {
                Console.WriteLine(evenNumber);
            }
            Console.WriteLine("That's all I have for you at the moment. Thanks for your time, and have a good day!");
        }
    }
}
