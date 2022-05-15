/*
https://www.codewars.com/kata/57e76bc428d6fbc2d500036d

8 kyu

Write a function to split a string and convert it into an array of words.

Examples (Input -> Output):
* "Robin Singh" ==> ["Robin", "Singh"]

* "I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]
*/
namespace CodeWars._8_kyu
{
    public class ConvertAStringToAnArray
    {
        public static string[] StringToArray(string str)
        {
            return str.Split(" ");
        }
    }
}
