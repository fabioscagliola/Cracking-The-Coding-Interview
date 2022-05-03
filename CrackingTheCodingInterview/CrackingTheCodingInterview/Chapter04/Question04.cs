using NUnit.Framework;
using System;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter04
{
    /// <summary>
    /// 
    /// ### 4.4 Check Balanced 
    /// 
    /// Implement a function to check if a binary tree is balanced. For the purposes of this question, a balanced tree is defined to be a tree such that the heights of the two subtrees of any node never differ by more than one. 
    /// 
    /// </summary>
    class Question04
    {
        static bool IsBalanced<T>(BinaryNode<T> binaryNode) where T : IComparable<T>
        {
            if (binaryNode == null)
            {
                return true;
            }

            if (Math.Abs(GetDepth(binaryNode.LChild) - GetDepth(binaryNode.RChild)) > 1)
            {
                return false;
            }
            else
            {
                return IsBalanced(binaryNode.LChild) && IsBalanced(binaryNode.RChild);
            }
        }

        static int GetDepth<T>(BinaryNode<T> binaryNode) where T : IComparable<T>
        {
            if (binaryNode == null)
            {
                return -1;
            }

            return Math.Max(GetDepth(binaryNode.LChild), GetDepth(binaryNode.RChild)) + 1;
        }

        [TestFixture]
        class Question04Test
        {
            [Test]
            public void Question04_IsBalanced()
            {
                /* 
                 * These are the binary trees used for testing purposes 
                 * 
                 * Balanced 
                 * 
                 *         1
                 *        / \
                 *       2   3
                 *      /
                 *     4
                 * 
                 * Unbalanced 
                 * 
                 *         1
                 *        / \
                 *       2   3
                 *      /
                 *     4
                 *    /
                 *   5
                 *  
                 */

                BinaryNode<int> balanced = new(1,
                    new BinaryNode<int>(2, new BinaryNode<int>(4)),
                    new BinaryNode<int>(3));

                Assert.IsTrue(IsBalanced(balanced));

                BinaryNode<int> unbalanced = new(1,
                    new BinaryNode<int>(2, new BinaryNode<int>(4, new BinaryNode<int>(5))),
                    new BinaryNode<int>(3));

                Assert.IsFalse(IsBalanced(unbalanced));
            }

        }

    }
}

