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
        static int ReturnKthToLast(LinkedList<int> linkedList, int k)
        {
            /*
             * 
             * Let us pretend that we are dealing with a singly linked list, 
             * therefore the Previous property of the LinkedListNode class cannot be used; 
             * and let us pretend that the LinkedList class does not implement the Count property 
             * 
             */

            LinkedListNode<int> linkedListNode = linkedList.First;

            int length = 0;

            while (linkedListNode != null)
            {
                length++;
                linkedListNode = linkedListNode.Next;
            }

            linkedListNode = linkedList.First;

            for (int i = 0; i < length - k; i++)
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

