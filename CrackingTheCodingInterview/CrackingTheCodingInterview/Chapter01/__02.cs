using System.Linq;
using NUnit.Framework;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter01
{
    /// <summary>
    /// 
    /// ### 1.2 Check Permutation 
    /// 
    /// Given two strings, write a method to decide it one is a permutation of the other. 
    /// 
    /// *The asymptotic computational complexity of my solution should be **O(n^2^)** where **n** is the length of the string* 
    /// 
    /// </summary>
    class __02
    {
        public static bool CheckPermutation(string s1, string s2)
        {
            bool result = false;



            return result;
        }

        [TestFixture]
        class __02Test
        {
            [Test]
            public void __02_CheckPermutation_ReturnsFalse()
            {
                Assert.IsFalse(__02.CheckPermutation("Laura", "Fabio"));
            }

            [Test]
            public void __02_CheckPermutation_ReturnsTrue()
            {
                Assert.IsTrue(__02.CheckPermutation("Laura", "auraL"));
            }

        }

    }
}

