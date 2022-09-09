/*

https://www.codewars.com/kata/57cc975ed542d3148f00015b

8 kyu

You will be given an array a and a value x. All you need to do is check whether the provided array contains the value.

Array can contain numbers or strings. X can be either.

Return true if the array contains the value, false if not.
 
*/
namespace CodeWars._8_kyu
{
    public class YouOnlyNeedOne
    {
        public static bool Check(object[] a, object x)
        {
            return a.Contains(x);

            //var result = Array.Find(a, i => i.Equals(x));
            //return result is null ? false: true;
        }
    }
}
