/*
https://www.codewars.com/kata/57241e0f440cd279b5000829

8 kyu

Your Job
Find the sum of all multiples of n below m

Keep in Mind
n and m are natural numbers (positive integers)
m is excluded from the multiples
Examples
Kata.SumMul(2, 9)   => 2 + 4 + 6 + 8 = 20
Kata.SumMul(3, 13)  => 3 + 6 + 9 + 12 = 30
Kata.SumMul(4, 123) => 4 + 8 + 12 + ... = 1860
Kata.SumMul(4, 1)   // throws ArgumentException
Kata.SumMul(0, 20)  // throws ArgumentException

*/
namespace CodeWars._8_kyu
{
    public class SumOfMultiples
    {
        public static int SumMul(int n, int m)
        {
            if (n <= 0 || n > m)
                throw new ArgumentException();

            int result = 0;
            for (int i = n; i < m; i += n)
                result += i;

            return result;
        }
    }
}
