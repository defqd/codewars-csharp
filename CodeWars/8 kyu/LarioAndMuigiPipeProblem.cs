/*
https://www.codewars.com/kata/56b29582461215098d00000f

8 kyu

Issue
Looks like some hoodlum plumber and his brother has been running around and damaging your stages again.

The pipes connecting your level's stages together need to be fixed before you receive any more complaints.

Pipes list is correct when each pipe after the first index is greater (+1) than the previous one, and that there is no duplicates.

Task
Given the a list of numbers, return a fixed list so that the values increment by 1 for each index from the minimum value up to the maximum
value (both included).

Example
Input: 1,3,5,6,7,8 Output: 1,2,3,4,5,6,7,8
*/

namespace CodeWars._8_kyu
{
    public class LarioAndMuigiPipeProblem
    {
        public static List<int> PipeFix(List<int> numbers)
        {
            return Enumerable.Range(numbers.First(), numbers.Last() - numbers.First() + 1).ToList();
        }

        //public static List<int> PipeFix(List<int> numbers)
        //{
        //    for (int i = 0; i < numbers.Count - 1; i++)
        //    {
        //        if (!(numbers[i] + 1 == numbers[i + 1]))
        //        {
        //            numbers.Add(numbers[i] + 1);
        //            numbers.Sort();
        //        }
        //    }
        //    return numbers;
        //}
    }
}
