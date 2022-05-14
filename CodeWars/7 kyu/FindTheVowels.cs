/*
https://www.codewars.com/kata/5680781b6b7c2be860000036

7 kyu

We want to know the index of the vowels in a given word, for example, there are two vowels in the word super (the second and fourth
letters).

So given a string "super", we should return a list of [2, 4].

Some examples:
Mmmm  => []
Super => [2,4]
Apple => [1,5]
YoMama -> [1,2,4,6]
NOTES
Vowels in this context refers to: a e i o u y (including upper case)
This is indexed from [1..n] (not zero indexed!)
*/

namespace CodeWars._7_kyu
{
    public class FindTheVowels
    {
        public static int[] VowelIndices(string word)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            var result = new List<int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(char.ToLower(word[i])))
                    result.Add(i + 1);
            }
            return result.ToArray();
        }
    }
}
