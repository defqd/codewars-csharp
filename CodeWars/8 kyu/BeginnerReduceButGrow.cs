/*
https://www.codewars.com/kata/57f780909f7e8e3183000078/csharp

8 kyu

Given a non-empty array of integers, return the result of multiplying the values together in order. Example:
[1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24

 */
namespace CodeWars._8_kyu
{
    public class BeginnerReduceButGrow
    {
        public static int Grow(int[] x)
        {
            int count = 1;

            for (int i = 0; i < x.Length; i++)
            {
                count *= x[i];
            }
            return count;
        }
    }
}
