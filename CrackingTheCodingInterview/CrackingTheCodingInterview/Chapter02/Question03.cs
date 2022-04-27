using NUnit.Framework;
using System.Collections.Generic;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter02
{
    /// <summary>
    /// 
    /// ### 2.3 Delete Middle Node 
    /// 
    /// Implement an algorithm to delete a node in the middle (i.e., any node but the first and last node, not necessarily the exact middle) of a singly linked list, given only access to that node. 
    /// 
    /// </summary>
    class Question03
    {
        static void DeleteMiddleNode<T>(LinkedListNode<T> linkedListNode)
        {
            linkedListNode.List.Remove(linkedListNode);
        }

        [TestFixture]
        class Question03Test
        {
            [Test]
            public void Question03_DeleteMiddleNode()
            {
                LinkedList<char> linkedList = new();
                linkedList.AddLast('a');
                linkedList.AddLast('b');
                LinkedListNode<char> linkedListNode = new('c');
                linkedList.AddLast(linkedListNode);
                linkedList.AddLast('d');
                linkedList.AddLast('e');
                linkedList.AddLast('f');
                Question03.DeleteMiddleNode(linkedListNode);
                CollectionAssert.AreEqual(new LinkedList<char>(new char[] { 'a', 'b', 'd', 'e', 'f' }), linkedList);
            }

        }

    }
}

