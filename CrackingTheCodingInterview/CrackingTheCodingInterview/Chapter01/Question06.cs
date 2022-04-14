using NUnit.Framework;
using System.Text;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter01
{
    /// <summary>
    /// 
    /// ### 1.6 String Compression 
    /// 
    /// Implement a method to perform basic string compression using the counts of repeated characters. For example, the string `aabcccccaaa` would become `a2b1c5a3`. If the "compressed" string would not become smaller than the original string, your method should return the original string. 
    /// 
    /// </summary>
    class Question06
    {
        static string StringCompression(string s)
        {
            StringBuilder stringBuilder = new StringBuilder();

            int count = 1;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (i == s.Length - 2 && s[i] == s[i + 1])
                {
                    count++;
                    stringBuilder.Append($"{s[i]}{count}");
                }
                if (s[i] == s[i + 1])
                {
                    count++;
                }
                else
                {
                    stringBuilder.Append($"{s[i]}{count}");
                    count = 1;
                }
            }

            return s.Length == stringBuilder.Length ? s : stringBuilder.ToString();
        }

        [TestFixture]
        class Question06Test
        {
            [Test]
            public void Question06_StringCompression()
            {
                Assert.AreEqual("a2b1c5a3", Question06.StringCompression("aabcccccaaa"));
            }

        }

    }
}

