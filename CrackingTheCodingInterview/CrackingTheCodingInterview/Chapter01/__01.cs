using NUnit.Framework;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter01
{
    /// <summary>
    /// 
    /// ### 1.1 Is Unique 
    /// 
    /// Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures? 
    /// 
    /// *The asymptotic computational complexity of my solution should be **O(n^2^)** where **n** is the length of the string* 
    /// 
    /// </summary>
    class __01
    {
        public static bool IsUnique(string s)
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
        class __01Test
        {
            [Test]
            public void __01_IsUnique_ReturnsFalse()
            {
                Assert.IsFalse(__01.IsUnique("Laura"));
            }

            [Test]
            public void __01_IsUnique_ReturnsTrue()
            {
                Assert.IsTrue(__01.IsUnique("Fabio"));
            }

        }

    }
}

