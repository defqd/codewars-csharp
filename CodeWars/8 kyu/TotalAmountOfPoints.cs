/*
 
https://www.codewars.com/kata/5bb904724c47249b10000131

8 kyu

Our football team has finished the championship.

Our team's match results are recorded in a collection of strings. Each match is represented by a string in the format "x:y", where x is our team's score and y is our opponents score.

For example: ["3:1", "2:2", "0:1", ...]

Points are awarded for each match as follows:

if x > y: 3 points (win)
if x < y: 0 points (loss)
if x = y: 1 point (tie)
We need to write a function that takes this collection and returns the number of points our team (x) got in the championship by the rules given above.

Notes:

our team always plays 10 matches in the championship
0 <= x <= 4
0 <= y <= 4
 
*/
namespace CodeWars._8_kyu
{
    public class TotalAmountOfPoints
    {
        public static int TotalPoints(string[] games)
        {
            //var result = 0;

            //var values = games.Select(x => x.Split(":").Select(int.Parse).ToArray());

            //foreach (var item in values)
            //{
            //    if (item[0] > item[1]) result += 3;
            //    if (item[0] == item[1]) result++;
            //}

            //foreach (var item in games.Select(x => x.Split(":")))
            //{
            //    if (int.Parse(item[0]) > int.Parse(item[1]))
            //        count += 3;
            //    else if (item[0] == item[1])
            //        count++;
            //}
            return games.Sum(s => s[0] > s[2] ? 3 : s[0] == s[2] ? 1 : 0);
        }
    }
}
