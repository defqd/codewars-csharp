/*
https://www.codewars.com/kata/564e1d90c41a8423230000bc/csharp

7 kyu

Knight vs King
If you are not familiar with chess game you can learn more Here .

Here is the chess board (rows, denoted by numbers, are called ranks, columns, denoted by a letter, are called files):

alt text

You put a Knight and a King in the board.

Complete the method that tell us which one can capture the other one.

You are provided with two object array; each contains an integer (the rank, first item) and a string/char (the file, second item) to show the position of the
pieces in the chess board.

Return:

"Knight" if the knight is putting the king in check,
"King" if the king is attacking the knight
"None" if none of the above occur
Example:

knight = [7, "B"], king = [6, "C"]  ---> "King"
Check the test cases and Happy coding :)
*/
namespace CodeWars._7_kyu
{
    public class KnightKing
    {
        public static string KnightVsKing(object[] knightPosition, object[] kingPosition)
        {
            var letters = new Dictionary<string, int>()
            {
                { "A", 1},
                { "B", 2},
                { "C", 3},
                { "D", 4},
                { "E", 5},
                { "F", 6},
                { "G", 7},
                { "H", 8},
            };

            if (Math.Abs((int)knightPosition[0] - (int)kingPosition[0]) <= 1 && 
                Math.Abs(letters[knightPosition[1].ToString()] - letters[kingPosition[1].ToString()]) <= 1)
                return "King";

            if(Math.Abs((int)knightPosition[0] - (int)kingPosition[0]) <= 2 && 
                Math.Abs(letters[knightPosition[1].ToString()] - letters[kingPosition[1].ToString()]) <= 2)
                return "Knight";

            return "None";
        }
    }
}
