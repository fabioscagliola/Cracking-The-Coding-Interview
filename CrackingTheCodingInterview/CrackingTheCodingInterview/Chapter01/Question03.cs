using NUnit.Framework;
using System.Text;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter01
{
    /// <summary>
    /// 
    /// ### 1.3 URLify 
    /// 
    /// Write a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient space at the end to hold the additional characters, and that you are given the "true" length of the string. 
    /// 
    /// </summary>
    class Question03
    {
        static string URLify(string s, int length)
        {
            StringBuilder stringBuilder = new();

            for (int i = 0; i < length; i++)
            {
                if (s[i] == ' ')
                {
                    stringBuilder.Append("%20");
                }
                else
                {
                    stringBuilder.Append(s[i]);
                }
            }

            return stringBuilder.ToString();
        }

        [TestFixture]
        class Question03Test
        {
            [Test]
            public void Question03_URLify()
            {
                Assert.AreEqual("Mr%20John%20Smith", Question03.URLify("Mr John Smith    ", 13));
            }

        }

    }
}

