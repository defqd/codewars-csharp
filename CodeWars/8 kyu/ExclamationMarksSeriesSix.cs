/*
https://www.codewars.com/kata/57faf7275c991027af000679

8 kyu

Description:
Remove n exclamation marks in the sentence from left to right. n is positive integer.

Examples
remove("Hi!",1) === "Hi"
remove("Hi!",100) === "Hi"
remove("Hi!!!",1) === "Hi!!"
remove("Hi!!!",100) === "Hi"
remove("!Hi",1) === "Hi"
remove("!Hi!",1) === "Hi!"
remove("!Hi!",100) === "Hi"
remove("!!!Hi !!hi!!! !hi",1) === "!!Hi !!hi!!! !hi"
remove("!!!Hi !!hi!!! !hi",3) === "Hi !!hi!!! !hi"
remove("!!!Hi !!hi!!! !hi",5) === "Hi hi!!! !hi"
remove("!!!Hi !!hi!!! !hi",100) === "Hi hi hi"

*/
namespace CodeWars._8_kyu
{
    public class ExclamationMarksSeriesSix
    {
        public static string Remove(string s, int n)
        {
            string s1 = "";
            foreach (char i in s)
            {
                if (i == '!' && n > 0)
                    n -= 1;
                else
                    s1 += i;
            }
            return s1;
        }
    }
}
