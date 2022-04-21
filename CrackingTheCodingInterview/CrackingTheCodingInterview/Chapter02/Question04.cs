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
        static void Partition<T>(LinkedList<T> linkedList, T value) where T : IComparable<T>
        {
            LinkedListNode<T> one = linkedList.First;

            while (one != null)
            {
                //LinkedListNode<T> two = one 


                one = one.Next;
            }
        }

        [TestFixture]
        class Question04Test
        {
            [Test]
            public void Question04_Partition()
            {
                LinkedList<int> linkedList = new(new int[] { 3, 5, 8, 5, 10, 2, 1 });
                Question04.Partition(linkedList, 5);
                CollectionAssert.AreEqual(new LinkedList<int>(new int[] { 3, 1, 2, 10, 5, 5, 8 }), linkedList);
            }

        }

    }
}

