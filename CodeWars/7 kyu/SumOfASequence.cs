/*

https://www.codewars.com/kata/586f6741c66d18c22800010a

7 kyu

Your task is to make function, which returns the sum of a sequence of integers.

The sequence is defined by 3 non-negative values: begin, end, step (inclusive).

If begin value is greater than the end, function should returns 0

Examples

2,2,2 --> 2
2,6,2 --> 12 (2 + 4 + 6)
1,5,1 --> 15 (1 + 2 + 3 + 4 + 5)
1,5,3  --> 5 (1 + 4)
*/

namespace CodeWars._7_kyu
{
    public class SumOfASequence
    {
        public static int SequenceSum(int start, int end, int step)
        {
            var result = new List<int>();

            for (int i = start; i <= end; i += step)
                result.Add(i);

            return result.Sum();
        }
    }
}