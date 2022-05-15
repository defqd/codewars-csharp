/*
https://www.codewars.com/kata/5b077ebdaf15be5c7f000077

8 kyu

If you can't sleep, just count sheep!!

Task:
Given a non-negative integer, 3 for example, return a string with a murmur: "1 sheep...2 sheep...3 sheep...". Input will always be valid,
i.e. no negative integers.
*/
namespace CodeWars._8_kyu
{
    public class JustCountSleep
    {
        public static string CountSheep(int n)
        {
            if (n <= 0)
                return "";
            if (n == 1)
                return "1 sheep...";

            return String.Join("...", (CountSheep(n - 1) + $"{n} sheep...").Split("..."));
        }
    }
}
