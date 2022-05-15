/*
https://www.codewars.com/kata/5a00e05cc374cb34d100000d

8 kyu

Build a function that returns an array of integers from n to 1 where n>0.

Example : n=5 --> [5,4,3,2,1]
*/
namespace CodeWars._8_kyu
{
    public class ReversedSequence
    {
        public static int[] ReverseSeq(int n)
        {
            return Enumerable.Range(1, n).Reverse().ToArray();
        }
    }
}
