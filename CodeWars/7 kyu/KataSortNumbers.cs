/*
https://www.codewars.com/kata/5174a4c0f2769dd8b1000003

7 kyu

Finish the solution so that it sorts the passed in array of numbers. If the function passes in an empty array or null/nil value then it
should return an empty array.

For example:

SortNumbers(new int[] { 1, 2, 10, 50, 5 }); // should return new int[] { 1, 2, 5, 10, 50 }
SortNumbers(null); // should return new int[] { }
*/
namespace CodeWars._7_kyu
{
    public class KataSortNumbers
    {
        public static int[] SortNumbers(int[] nums)
        {
            if (nums == null)
                return new int[] { };
            Array.Sort(nums);
            return nums;
        }
    }
}
