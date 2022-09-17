/*
 
https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3

8 kyu

Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

The output should be two capital letters with a dot separating them.

It should look like this:

Sam Harris => S.H

patrick feeney => P.F

 */
namespace CodeWars._8_kyu
{
    public class AbbreviateATwoWordName
    {
        public static string AbbrevName(string name)
        {
            return String.Join(".", name.Split(" ").Select(x => char.ToUpper(x[0])));

            //return $"{name[0]}.{name[name.IndexOf(' ') + 1]}".ToUpper();
        }
    }
}