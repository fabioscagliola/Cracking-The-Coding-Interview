using NUnit.Framework;
using System;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter01
{
    /// <summary>
    /// 
    /// ### 1.2 Check Permutation 
    /// 
    /// Given two strings, write a method to decide it one is a permutation of the other. 
    /// 
    /// </summary>
    class Question02
    {
        static bool CheckPermutation(string s1, string s2)
        {
            return SortString(s1) == SortString(s2);
        }

        static string SortString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            return new string(charArray);
        }

        [TestFixture]
        class Question02Test
        {
            [Test]
            public void Question02_CheckPermutation_ReturnsFalse()
            {
                Assert.IsFalse(Question02.CheckPermutation("Laura", "Fabio"));
            }

            [Test]
            public void Question02_CheckPermutation_ReturnsTrue()
            {
                Assert.IsTrue(Question02.CheckPermutation("Laura", "auraL"));
            }

        }

    }
}

