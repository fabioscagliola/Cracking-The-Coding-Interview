using NUnit.Framework;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter01
{
    /// <summary>
    /// 
    /// ### 1.5 One Away 
    /// 
    /// There are three types of edits that can be performed on strings: insert a character, remove a character, or replace a character. Given two strings, write a function to check if they are one edit (or zero edits) away. 
    /// 
    /// </summary>
    class Question05
    {
        static bool OneAway(string s1, string s2)
        {
            if (s2.Length > s1.Length + 1)
                return false;

            if (s2.Length < s1.Length - 1)
                return false;

            if (s1.Length == s2.Length + 1)  // A character was removed 
            {
                for (int i = 0; i < s2.Length; i++)
                {
                    if (!s1.Contains(s2[i]))
                    {
                        return false;
                    }
                }
            }
            else if (s1.Length == s2.Length - 1)  // A character was inserted 
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (!s2.Contains(s1[i]))
                    {
                        return false;
                    }
                }
            }
            else if (s2.Length == s1.Length)  // A character was replaced 
            {
                for (int i = 0; i < s1.Length - 1; i++)
                {
                    if (s1[i] != s2[i] && s1[i + 1] != s2[i + 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        [TestFixture]
        class Question05Test
        {
            [Test]
            public void Question05_OneAway_ReturnsTrue()
            {
                Assert.IsTrue(Question05.OneAway("pale", "ple"));
                Assert.IsTrue(Question05.OneAway("pale", "pales"));
                //Assert.IsTrue(Question05.OneAway("pale", "bale"));
            }

            [Test]
            public void Question05_OneAway_ReturnsFalse()
            {
                Assert.IsFalse(Question05.OneAway("pale", "bake"));
                Assert.IsFalse(Question05.OneAway("abcd", "abcdef"));
                Assert.IsFalse(Question05.OneAway("abcd", "ab"));
            }

        }

    }
}

