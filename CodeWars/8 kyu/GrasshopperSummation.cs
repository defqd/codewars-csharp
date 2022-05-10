/*
https://www.codewars.com/kata/55d24f55d7dd296eb9000030

8 kyu

Summation
Write a program that finds the summation of every number from 1 to num. The number will always be a positive integer greater
than 0.

For example:

summation(2) -> 3
1 + 2

summation(8) -> 36
1 + 2 + 3 + 4 + 5 + 6 + 7 + 8

 */
namespace CodeWars._8_kyu
{
    public class GrasshopperSummation
    {
        public static int Summation(int num)
        {
            return ((int)Math.Pow(num, 2) + num) / 2;
        }
    }
}
