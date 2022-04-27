using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter02
{
    /// <summary>
    /// 
    /// ### 2.4 Partition 
    /// 
    /// Write code to partition a linked list around a value x, such that all nodes less than x come before all nodes greater than or equal to x. 
    /// 
    /// </summary>
    class Question04
    {
        static LinkedList<T> Partition<T>(LinkedList<T> linkedList, T value) where T : IComparable<T>
        {
            LinkedList<T> result = new();

            LinkedListNode<T> linkedListNode = linkedList.Find(value);

            while (linkedListNode != null)
            {
                AddFirstOrLast(result, linkedListNode, value);

                linkedListNode = linkedListNode.Next;
            }

            linkedListNode = linkedList.Find(value).Previous;

            while (linkedListNode != null)
            {
                AddFirstOrLast(result, linkedListNode, value);

                linkedListNode = linkedListNode.Previous;
            }

            return result;
        }

        /// <summary>
        /// Adds a node to the head of a linked list if the value of the node is lower than the specified value, otherwise it adds it to the tail 
        /// </summary>
        static void AddFirstOrLast<T>(LinkedList<T> linkedList, LinkedListNode<T> linkedListNode, T value) where T : IComparable<T>
        {
            if (linkedListNode.Value.CompareTo(value) == -1)
            {
                linkedList.AddFirst(linkedListNode.Value);
            }
            else
            {
                linkedList.AddLast(linkedListNode.Value);
            }
        }

        [TestFixture]
        class Question04Test
        {
            [Test]
            public void Question04_Partition()
            {
                LinkedList<int> linkedList = new(new int[] { 3, 5, 8, 5, 10, 2, 1 });
                linkedList = Question04.Partition(linkedList, 5);
                CollectionAssert.AreEqual(new LinkedList<int>(new int[] { 3, 1, 2, 5, 8, 5, 10 }), linkedList);
            }

        }

    }
}

