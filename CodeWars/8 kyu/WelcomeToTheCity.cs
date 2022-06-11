/*
https://www.codewars.com/kata/5302d846be2a9189af0001e4

8 kyu

Create a method sayHello/say_hello/SayHello that takes as input a name, city, and state to welcome a person. Note that name will be an array consisting of one or
more values that should be joined together with one space between each, and the length of the name array in test cases will vary.

Example:

Kata.SayHello(new String[]{"John", "Smith"}, "Phoenix", "Arizona")
This example will return the string Hello, John Smith! Welcome to Phoenix, Arizona!

*/
namespace CodeWars._8_kyu
{
    public class WelcomeToTheCity
    {
        public static string SayHello(string[] name, string city, string state)
        {
            return $"Hello, {string.Join(" ", name)}! Welcome to {city}, {state}!";
        }
    }
}
