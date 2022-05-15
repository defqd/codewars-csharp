/*
https://www.codewars.com/kata/5748838ce2fab90b86001b1a

8 kyu

Complete the function that calculates the area of the red square, when the length of the circular arc A is given as the input. Return the
result rounded to two decimals.

Note: use the π value provided in your language (Math::PI, M_PI, math.pi, etc)
*/
namespace CodeWars._8_kyu
{
    public class AreaOfASquare
    {
        public static double SquareArea(double A)
        {
            return Math.Round(Math.Pow(A * 4 / (Math.PI * 2), 2), 2);
        }
    }
}
