/*
https://www.codewars.com/kata/5769b3802ae6f8e4890009d2

8 kyu

Take an array and remove every second element from the array. Always keep the first element and start removing with the next element.

Example:

["Keep", "Remove", "Keep", "Remove", "Keep", ...] --> ["Keep", "Keep", "Keep", ...]

None of the arrays will be empty, so you don't have to worry about that!
*/

namespace CodeWars._8_kyu
{
    public class RemovingElements
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            var result = new List<object>();

            for (int i = 0; i < arr.Length; i += 2)
                result.Add(arr[i]);

            return result.ToArray();
        }
    }
}
