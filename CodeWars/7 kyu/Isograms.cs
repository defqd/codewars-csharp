/*

7 kyu

https://www.codewars.com/kata/54ba84be607a92aa900000f1/train/csharp

An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

Example: (Input --> Output)

"Dermatoglyphics" --> true "aba" --> false "moOse" --> false (ignore letter case)

isIsogram "Dermatoglyphics" = true
isIsogram "moose" = false
isIsogram "aba" = false
 
*/
namespace CodeWars._7_kyu
{
    public class Isograms
    {
        public static bool IsIsogram(string str)
        {
            return str.ToLower().Distinct().Count() == str.Length;

            //    var list = new List<char>();

            //    foreach (var item in str.ToLower())
            //    {
            //        if (!list.Contains(item))
            //        {
            //            list.Add(item);
            //        }
            //    }

            //    return new string(list.ToArray()) == str.ToLower();
        }
    }
}