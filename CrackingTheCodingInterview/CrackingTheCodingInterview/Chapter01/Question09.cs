using NUnit.Framework;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter01
{
    /// <summary>
    /// 
    /// ### 1.9 String Rotation 
    /// 
    /// Assume you have a method `isSubstring` which checks if one word is a substring of another. Given two strings, `s1` and `s2`, write code to check if `s2` is a rotation of `s1` using only one call to `isSubstring` (e.g., "waterbottle" is a rotation of "erbottlewat"). 
    /// 
    /// </summary>
    class Question09
    {
        static bool StringRotation(string s1, string s2)
        {
            return string.Concat(s1, s1).Contains(s2);
        }

        [TestFixture]
        class Question07Test
        {
            [Test]
            public void Question07_ZeroMatrix_ReturnsTrue()
            {
                Assert.IsTrue(Question09.StringRotation("waterbottle", "erbottlewat"));
            }

        }

    }
}

