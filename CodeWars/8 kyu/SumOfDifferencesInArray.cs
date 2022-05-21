/*
https://www.codewars.com/kata/5b73fe9fb3d9776fbf00009e

8 kyu

Your task is to sum the differences between consecutive pairs in the array in descending order.

For example:

SumOfDifferences(new int[] { 2, 1, 10 })
Returns 9

Descending order: [10, 2, 1]

Sum: (10 - 2) + (2 - 1) = 8 + 1 = 9

If the array is empty or the array has only one element the result should be 0 (Nothing in Haskell).
*/
namespace CodeWars._8_kyu
{
    public class SumOfDifferencesInArray
    {
        public static int SumOfDifferences(int[] arr)
        {
            //Array.Sort(arr);

            //int sum = 0;
            //for (int i = 1; i < arr.Length; i++)
            //    sum += arr[i] - arr[i - 1];

            //return sum;

            return arr.Any() ? arr.Max() - arr.Min() : 0;
        }
    }
}
