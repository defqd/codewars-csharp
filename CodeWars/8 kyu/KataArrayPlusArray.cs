﻿/*
 
https://www.codewars.com/kata/5a2be17aee1aaefe2a000151

8 kyu

I'm new to coding and now I want to get the sum of two arrays... Actually the sum of all their elements. I'll appreciate for your help.

P.S. Each array includes only integer numbers. Output is a number too.

*/

namespace CodeWars._8_kyu
{
    public class KataArrayPlusArray
    {
        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            return arr1.Sum() + arr2.Sum();
        }
    }
}
