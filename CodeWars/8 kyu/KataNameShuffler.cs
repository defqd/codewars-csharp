/*
https://www.codewars.com/kata/559ac78160f0be07c200005a

8 kyu 

Write a function that returns a string in which firstname is swapped with last name.

Kata.NameShuffler("john McClane") => "McClane john"
*/
namespace CodeWars._8_kyu
{
    public class KataNameShuffler
    {
        public static string NameShuffler(string str)
        {
            var splitStr = str.Split(' ');
            return string.Join(" ", splitStr[1], splitStr[0]);
        }
    }
}
