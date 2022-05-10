﻿/*
https://www.codewars.com/kata/542c0f198e077084c0000c2e

7 kyu

Count the number of divisors of a positive integer n.

Random tests go up to n = 500000.

Examples (input --> output)
4 --> 3 (1, 2, 4)
5 --> 2 (1, 5)
12 --> 6 (1, 2, 3, 4, 6, 12)
30 --> 8 (1, 2, 3, 5, 6, 10, 15, 30)

*/

namespace CodeWars._7_kyu
{
    public class CountTheDivisorsOfANumber
    {
        public static int Divisors(int n)
        {
            int j = 0;
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = i + 1;
                if (n % mas[i] == 0)
                {
                    j++;
                }
            }
            return j;
        }
    }
}
