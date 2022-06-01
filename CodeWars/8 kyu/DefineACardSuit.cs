/*
https://www.codewars.com/kata/5a360620f28b82a711000047/train/csharp

8 kyu

You get any card as an argument. Your task is to return the suit of this card (in lowercase).

Our deck (is preloaded):

string[] Deck =
{
    "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣",
    "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦",
    "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥",
    "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠"
};
DefineSuit("3♣") -> return "clubs"
DefineSuit("3♦") -> return "diamonds"
DefineSuit("3♥") -> return "hearts"
DefineSuit("3♠") -> return "spades"
*/
namespace CodeWars._8_kyu
{
    public class DefineACardSuit
    {
        public static string DefineSuit(string card) =>
            card[^1] switch
            {
                '♣' => "clubs",
                '♦' => "diamonds",
                '♥' => "hearts",
                _ => "spades",
            };
        //public static string DefineSuit(string card)
        //{
        //    if (card.Contains("♣"))
        //        return "clubs";
        //    else if (card.Contains("♦"))
        //        return "diamonds";
        //    else if (card.Contains("♥"))
        //        return "hearts";
        //    else
        //        return "spades";
        //}
    }
}
