/********
**
** Name: McQueen, Robert
** Class: CS 132
** Project: HOP03
** Date: 2020-07-26
** Description: Part 1, Numeric Operators
** 
********/

using System;
using static System.Console;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 77;
            float num3 = 5.2f; // float is used due to the value of 5.2 not being of type int

            float sum = num1 + num2 + num3; // Sum  20+77+5.2=102.2
            int subtract = num2 - num1;     // Difference 77-20=57
            int multiply = num1 * num2;     // Product 77*22=1540
            float divide = num1 / num3;     // Quotient 20/5.2=3.846154  float divide is used in place of int due to num3 being a floating point number, int would require a an explicit cast which would result in a truncation after the decimal 
            int modulus = num2 % num1;      // Remainder 77%20=17

            WriteLine("Sum of 3 numbers is: " + sum);
            WriteLine("77 - 20 is: " + subtract);
            WriteLine("20 * 77 is: " + multiply);
            WriteLine("20 / 5.2 is: " + divide);
            WriteLine("77 % 20 is: " + modulus);
        }
    }
}
