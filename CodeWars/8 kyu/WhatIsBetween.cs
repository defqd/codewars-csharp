/*
https://www.codewars.com/kata/55ecd718f46fba02e5000029

8 kyu

Complete the function that takes two integers (a, b, where a < b) and return an array of all integers between the input parameters, including them.

For example:

a = 1
b = 4
--> [1, 2, 3, 4]
*/
namespace CodeWars._8_kyu
{
    public class WhatIsBetween
    {
        public static int[] Between(int a, int b)
        {
            return Enumerable.Range(a, b + 1 - a).ToArray();
        }
    }
}
