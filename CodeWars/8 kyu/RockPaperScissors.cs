﻿/*
https://www.codewars.com/kata/5672a98bdbdd995fad00000f

8 kyu

Rock Paper Scissors
Let's play! You have to return which player won! In case of a draw return Draw!.

Examples:

rps('scissors','paper') // Player 1 won!
rps('scissors','rock') // Player 2 won!
rps('paper','paper') // Draw!

*/

namespace CodeWars._8_kyu
{
    public class RockPaperScissors
    {
        public string Rps(string p1, string p2)
        {
            if (p1 == p2)
                return "Draw!";
            switch (p1)
            {
                case "rock":
                    if (p2 == "scissors") return "Player 1 won!";
                    if (p2 == "paper") return "Player 2 won!";
                    break;
                case "scissors":
                    if (p2 == "paper") return "Player 1 won!";
                    if (p2 == "rock") return "Player 2 won!";
                    break;
                case "paper":
                    if (p2 == "rock") return "Player 1 won!";
                    if (p2 == "scissors") return "Player 2 won!";
                    break;
            }
            return "";
        }
    }
}
