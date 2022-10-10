using CodeWars._7_kyu;
using NUnit.Framework;
using System;
using System.Text;

namespace CodeWarsTests._7_kyu
{
    [TestFixture]
    public class PartsOfAListTests
    {

        private static string DeepToString(string [][] array)
        {
            var result = new StringBuilder();
            result.Append("[");
            for (int i = 0; i < array.Length; i++)
            {
                result.Append("[");
                for (int j = 0; j < array[j].Length; j++)
                {
                    result.Append(array[i][j]);
                    result.Append(", ");   
                }
                result.Remove(result.Length - 2, 2);
                result.Append("], ");
            }
            result.Remove(result.Length - 2, 2);
            result.Append("]");


            return result.ToString();
        }
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void test0()
        {
            Console.WriteLine("Fixed Tests Partlist");

            string[] s1 = new string[] { "cdIw", "tzIy", "xDu", "rThG" };
            string a = "[[cdIw, tzIy xDu rThG], [cdIw tzIy, xDu rThG], [cdIw tzIy xDu, rThG]]";
            testing(DeepToString(PartsOfAList.Partlist(s1)), a);
            

            s1 = new string[] { "I", "wish", "I", "hadn't", "come" };
            a = "[[I, wish I hadn't come], [I wish, I hadn't come], [I wish I, hadn't come], [I wish I hadn't, come]]";
            testing(DeepToString(PartsOfAList.Partlist(s1)), a);

            s1 = new string[] { "vJQ", "anj", "mQDq", "sOZ" };
            a = "[[vJQ, anj mQDq sOZ], [vJQ anj, mQDq sOZ], [vJQ anj mQDq, sOZ]]";
            testing(DeepToString(PartsOfAList.Partlist(s1)), a);
        }
    }
}