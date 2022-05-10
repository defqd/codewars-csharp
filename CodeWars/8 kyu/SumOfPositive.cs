/*
 
https://www.codewars.com/kata/5715eaedb436cf5606000381
 
8 kyu
 
You get an array of numbers, return the sum of all of the positives ones.

Example [1,-4,7,12] => 1 + 7 + 12 = 20

Note: if there is nothing to sum, the sum is default to 0.
 
*/
namespace CodeWars._8_kyu
{
    public class SumOfPositive
    {
        public static int PositiveSum(int[] arr)
        {
            int j = 0;

            foreach (int i in arr)
            {
                int res = i >= 0 ? j += i : 0;
            }
            Console.WriteLine(j);
            return j;

        }
    }
}
