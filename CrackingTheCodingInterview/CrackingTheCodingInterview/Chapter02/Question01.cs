using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter02
{
    /// <summary>
    /// 
    /// ### 2.1 Remove Dups 
    /// 
    /// Write code to remove duplicates from an unsorted linked list. How would you solve this problem if a temporary buffer is not allowed? 
    /// 
    /// </summary>
    class Question01
    {
        static void RemoveDups<T>(LinkedList<T> linkedList) where T : IEquatable<T>
        {
            LinkedListNode<T> one = linkedList.First;

            while (one != null)
            {
                LinkedListNode<T> two = one.Next;

                while (two != null)
                {
                    if (one.Value.Equals(two.Value))
                    {
                        linkedList.Remove(two);
                    }

                    two = two.Next;
                }

                one = one.Next;
            }
        }

        [TestFixture]
        class Question01Test
        {
            [Test]
            public void Question01_RemoveDups()
            {
                LinkedList<int> linkedList = new(new int[] { 1, 9, 7, 5, 0, 1, 2, 3 });
                Question01.RemoveDups(linkedList);
                CollectionAssert.AreEqual(new LinkedList<int>(new int[] { 1, 9, 7, 5, 0, 2, 3 }), linkedList);
            }

        }

    }
}

