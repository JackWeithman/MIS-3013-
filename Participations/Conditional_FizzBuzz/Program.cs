﻿using System;

namespace Conditional_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            
            if(number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            if(number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            if(number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine(number);
            }

            
        }
    }
}
