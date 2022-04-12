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
            List<List<char>> permutations = new List<List<char>>();
            Heap(s.ToCharArray().ToList(), s.Length, permutations);
            return permutations.Select(x => new string(x.ToArray())).Contains(s);
        }

        static List<List<T>> Heap<T>(List<T> A, int k, List<List<T>> result)
        {
            if (k == 1)
            {
                result.Add(new List<T>(A));
            }
            else
            {
                Heap(A, k - 1, result);

                for (int i = 0; i < k - 1; i++)
                {
                    if (k % 2 == 0)
                    {
                        Swap(A, i, k - 1);
                    }
                    else
                    {
                        Swap(A, 0, k - 1);
                    }

                    Heap(A, k - 1, result);
                }
            }

            return result;
        }

        static void Swap<T>(List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
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

