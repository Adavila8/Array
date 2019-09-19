/*
Author: Aaron Davila
Date: 09/18/2019
Class: ISM 4300
Description: Creating an Array for a class deliverable 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting an Array with 25 elements within it. 
            int[] Array = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            for (int i = 1; i < 26; i++)
            {
                // WriteLine for information to display an iteration of each element within the Array.
                Console.WriteLine("Element Value = " + Array[i]);
                // An ending WriteLine statement to allow the user to know the array has finished.
                if (Array[i] == 25)
                {
                    Console.WriteLine("Your Array Has Ended");
                }
            }
            Console.ReadKey(true); // Need a ready key to read lines for computer
        }
    }
}
