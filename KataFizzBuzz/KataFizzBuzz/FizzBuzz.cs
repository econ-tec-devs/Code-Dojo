// -----------------------------------------------------------------------
// <copyright file="FizzBuzz.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace KataFizzBuzz
{
    public class FizzBuzz
    {
        public void Print()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
           
               
                /* Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("Fizz");
                Console.WriteLine("4");
                Console.WriteLine("Buzz");
                Console.WriteLine("Fizz");*/
            }
           
            
        }
    }
}
