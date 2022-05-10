/*
https://www.codewars.com/kata/57f781872e3d8ca2a000007e

8 kuy

Given an array of integers, return a new array with each value doubled.

For example:

[1, 2, 3] --> [2, 4, 6]
 
*/


namespace CodeWars._8_kyu
{
    public class BeginnerLostWithoutAMap
    {
        public static int[] Maps(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] *= 2;
            }
            return x;
        }
    }
}
