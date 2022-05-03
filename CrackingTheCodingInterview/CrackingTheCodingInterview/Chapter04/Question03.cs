using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter04
{
    /// <summary>
    /// 
    /// ### 4.3 List of Depths 
    /// 
    /// Given a binary tree, design an algorithm which creates a linked list of all the nodes at each depth (e.g., if you have a tree with depth D, you'll have D linked lists). 
    /// 
    /// </summary>
    class Question03
    {
        static List<LinkedList<BinaryNode<T>>> ListOfDepths<T>(BinaryNode<T> binaryNode) where T : IComparable<T>
        {
            List<LinkedList<BinaryNode<T>>> result = new();
            DoLinkedList(result, binaryNode, 0);
            return result;
        }

        static void DoLinkedList<T>(List<LinkedList<BinaryNode<T>>> lists, BinaryNode<T> binaryNode, int d) where T : IComparable<T>
        {
            if (binaryNode == null)
            {
                return;
            }

            LinkedList<BinaryNode<T>> linkedList;

            if (lists.Count == d)
            {
                linkedList = new();
                lists.Add(linkedList);
            }
            else
            {
                linkedList = lists[d];
            }

            linkedList.AddLast(binaryNode);

            DoLinkedList(lists, binaryNode.LChild, d + 1);
            DoLinkedList(lists, binaryNode.RChild, d + 1);
        }

        [TestFixture]
        class Question03Test
        {
            [Test]
            public void Question03_ListOfDepths()
            {
                /* 
                 * This is the binary tree used for testing purposes 
                 * 
                 *         1
                 *        / \
                 *       2   3
                 *      /   / \
                 *     4   5   6
                 * 
                 */

                BinaryNode<int> binaryNode = new(1, 
                    new BinaryNode<int>(2, new BinaryNode<int>(4)), 
                    new BinaryNode<int>(3, new BinaryNode<int>(5), new BinaryNode<int>(6)));

                List<LinkedList<BinaryNode<int>>> result = ListOfDepths(binaryNode);

                Assert.AreEqual(3, result.Count);
                CollectionAssert.AreEqual(new LinkedList<int>(new int[] { 1 }), result[0].Select(x => x.Value));
                CollectionAssert.AreEqual(new LinkedList<int>(new int[] { 2, 3 }), result[1].Select(x => x.Value));
                CollectionAssert.AreEqual(new LinkedList<int>(new int[] { 4, 5, 6 }), result[2].Select(x => x.Value));
            }

        }

    }
}

