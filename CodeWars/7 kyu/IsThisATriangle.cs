/*
https://www.codewars.com/kata/56606694ec01347ce800001b/train/csharp

7 kyu 

Implement a function that accepts 3 integer values a, b, c. The function should return true if a triangle can be built with
the sides of given length and false in any other case.

(In this case, all triangles must have surface greater than 0 to be accepted).

 */
namespace CodeWars._7_kyu
{
    public class IsThisATriangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
