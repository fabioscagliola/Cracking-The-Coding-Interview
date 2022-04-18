using NUnit.Framework;
using System.Collections.Generic;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter02
{
    /// <summary>
    /// 
    /// ### 2.2 Return Kth to Last 
    /// 
    /// Implement an algorithm to find the kth to last element of a singly linked list. 
    /// 
    /// </summary>
    class Question02
    {
        static T ReturnKthToLast<T>(LinkedList<T> linkedList, int k)
        {
            /*
             * 
             * Let us pretend that we are dealing with a singly linked list, 
             * therefore the Previous property of the LinkedListNode class cannot be used 
             * 
             */

            LinkedListNode<T> linkedListNode = linkedList.First;

            for (int i = 0; i < linkedList.Count - k; i++)
            {
                linkedListNode = linkedListNode.Next;
            }

            return linkedListNode.Value;
        }

        [TestFixture]
        class Question02Test
        {
            [Test]
            public void Question02_ReturnKthToLast()
            {
                LinkedList<int> linkedList = new(new int[] { 1, 9, 7, 5, 0, 1, 2, 3 });
                Assert.AreEqual(0, Question02.ReturnKthToLast(linkedList, 4));
            }

        }

    }
}

