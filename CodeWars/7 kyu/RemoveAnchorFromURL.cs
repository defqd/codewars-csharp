/*

https://www.codewars.com/kata/51f2b4448cadf20ed0000386

7 kuy

Complete the function/method so that it returns the url with anything after the anchor (#) removed.

Examples
"www.codewars.com#about" --> "www.codewars.com"
"www.codewars.com?page=1" -->"www.codewars.com?page=1"

*/

namespace CodeWars._7_kyu
{
    public class RemoveAnchorFromURL
    {
        public static string RemoveUrlAnchor(string url)
        {
            return url.Split('#')[0];
        }
    }
      

}
