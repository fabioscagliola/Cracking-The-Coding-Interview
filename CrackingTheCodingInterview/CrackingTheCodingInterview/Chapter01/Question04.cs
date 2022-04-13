using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter01
{
    /// <summary>
    /// 
    /// ### 1.4 Palindrome Permutation 
    /// 
    /// Given a string, write a function to check if it is a permutation of a palindrome. A palindrome is a word or phrase that is the same forwards and backwards. A permutation is a rearrangement of letters. The palindrome does not need to be limited to just dictionary words. You can ignore casing and non-letter characters. 
    /// 
    /// </summary>
    class Question04
    {
        static bool PalindromePermutation(string s)
        {
            List<List<char>> permutations = s.ToCharArray().ToList().GeneratePermutations();
            return permutations.Select(x => new string(x.ToArray())).Contains(s);
        }

        [TestFixture]
        class Question04Test
        {
            [Test]
            public void Question04_PalindromePermutation_ReturnsTrue()
            {
                Assert.IsTrue(Question04.PalindromePermutation("Tact Toa"));
            }

        }

    }
}

