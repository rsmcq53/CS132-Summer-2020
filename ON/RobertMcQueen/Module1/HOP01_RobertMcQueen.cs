/********

**

** Name: McQueen, Robert

** Class: CS 132

** Project: HOP01

** Date: 2020-07-12

** Description: This is my submission for the first hands on practice.

**The code is a basic name, age, gender display

**using information added to the strings, for output on the console.

**

********/




using System;
using static System.Console;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Robert";         // add a preferred name
            int Age = 45;                   // how old are you? (or how old do you feel)
            bool isFemale = false;          // antiquated gender format goes here
            double MyFloat = 10.1;          // arbitrary number??

            WriteLine(Name);
            WriteLine(Age);
            WriteLine(isFemale);
            WriteLine(MyFloat);
        }
    }
}


