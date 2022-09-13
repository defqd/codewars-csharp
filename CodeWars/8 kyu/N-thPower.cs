/*

https://www.codewars.com/kata/57d814e4950d8489720008db

8 kyu

N-th PoweThis kata is from check py.checkio.org

You are given an array with positive numbers and a non-negative number N. You should find the N-th power of the element in the array with the index N. If N is outside of the array, then return -1. Don't forget that the first element has the index 0.

Let's look at a few examples:

array = [1, 2, 3, 4] and N = 2, then the result is 3^2 == 9;
array = [1, 2, 3] and N = 3, but N is outside of the array, so the result is -1.
 
*/
namespace CodeWars._8_kyu
{
    public class N_thPower
    {
        public static double Index(int[] array, int n)
        {
            try
            {
                return Math.Pow(array[n], n);
            }
            catch
            {
                return -1;
            }
        }

        //public static double Index(int[] array, int n) => n < array.Length ? Math.Pow(array[n], n) : -1;

        //public static double Index(int[] array, int n)
        //{
        //    if (array.Length - 1 >= n)
        //        return array.Contains(array[n]) ? Math.Pow(array[n], n) : -1;

        //    else return -1;
        //}
    }
}