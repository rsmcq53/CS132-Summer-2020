/********
**
** Name: McQueen, Robert
** Class: CS 132
** Project: HOP03
** Date: 2020-07-26
** Description: Increment and Decrement operators and their operations on variables and values.
** 
********/

using System;
using static System.Console;

namespace Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a <= 10; a++) // increments the values from 0 to 10, returning the values less than or equal to 10.
                WriteLine(a);

            for (int b = 15; b > 0; b--) // decrements b from 15 to 1 returning the value of all number greater than zero, ending the loop at 0.
                WriteLine(b);


        }
    }
}