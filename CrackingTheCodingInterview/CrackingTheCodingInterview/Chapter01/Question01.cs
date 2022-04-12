using NUnit.Framework;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter01
{
    /// <summary>
    /// 
    /// ### 1.1 Is Unique 
    /// 
    /// Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures? 
    /// 
    /// </summary>
    class Question01
    {
        static bool IsUnique(string s)
        {
            bool result = true;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        [TestFixture]
        class Question01Test
        {
            [Test]
            public void Question01_IsUnique_ReturnsFalse()
            {
                Assert.IsFalse(Question01.IsUnique("Laura"));
            }

            [Test]
            public void Question01_IsUnique_ReturnsTrue()
            {
                Assert.IsTrue(Question01.IsUnique("Fabio"));
            }

        }

    }
}

