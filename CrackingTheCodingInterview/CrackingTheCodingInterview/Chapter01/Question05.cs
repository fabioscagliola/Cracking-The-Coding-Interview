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
        static bool OneAway(string a, string b)
        {
            // A character was inserted 
            if (a.Length == b.Length - 1)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (!b.Contains(a[i]))
                    {
                        return false;
                    }
                }
            }

            // A character was removed 
            if (a.Length == b.Length + 1)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    if (!a.Contains(b[i]))
                    {
                        return false;
                    }
                }
            }

            // A character was replaced 
            if (b.Length == a.Length)
            {
                int replacedCharacters = 0;

                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] != b[i])
                    {
                        replacedCharacters++;

                        if (replacedCharacters > 1)
                        {
                            return false;
                        }
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
                Assert.IsTrue(Question05.OneAway("pales", "pale"));
                Assert.IsTrue(Question05.OneAway("pale", "bale"));
            }

            [Test]
            public void Question05_OneAway_ReturnsFalse()
            {
                Assert.IsFalse(Question05.OneAway("pale", "bake"));
            }

        }

    }
}

