/*

https://www.codewars.com/kata/57a5b0dfcf1fa526bb000118

8 kyu

Define a function that removes duplicates from an array of numbers and returns it as a result.

The order of the sequence has to stay the same.
 
*/

namespace CodeWars._8_kyu
{
    public class RemoveDuplicatesFromList
    {
        public static int[] Distinct(int[] a)
        {
            return a.Distinct().ToArray();
        }
    }
}