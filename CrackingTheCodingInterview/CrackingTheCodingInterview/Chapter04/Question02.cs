using NUnit.Framework;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter04
{
    /// <summary>
    /// 
    /// ### 4.2 Minimal Tree 
    /// 
    /// Given a sorted (increasing order) array with unique integer elements, write an algorithm to create a binary search tree with minimal height. 
    /// 
    /// </summary>
    class Question02
    {
        static BinaryNode<int> MinimalTree(int[] list)
        {
            return CreateBinarySearchTree(list, 0, list.Length - 1);
        }

        static BinaryNode<int> CreateBinarySearchTree(int[] list, int begin, int end)
        {
            if (end < begin) return null;
            int median = (begin + end) / 2;
            BinaryNode<int> lChild = CreateBinarySearchTree(list, begin, median - 1);
            BinaryNode<int> rChild = CreateBinarySearchTree(list, median + 1, end);
            BinaryNode<int> binaryNode = new(list[median], lChild, rChild);
            return binaryNode;
        }

        [TestFixture]
        class Question02Test
        {
            [Test]
            public void Question02_MinimalTree()
            {
                BinaryNode<int> binaryNode = MinimalTree(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });

                Assert.AreEqual(4, binaryNode.Value);
                Assert.AreEqual(2, binaryNode.LChild.Value);
                Assert.AreEqual(1, binaryNode.LChild.LChild.Value);
                Assert.AreEqual(3, binaryNode.LChild.RChild.Value);
                Assert.AreEqual(6, binaryNode.RChild.Value);
                Assert.AreEqual(5, binaryNode.RChild.LChild.Value);
                Assert.AreEqual(7, binaryNode.RChild.RChild.Value);
                Assert.AreEqual(8, binaryNode.RChild.RChild.RChild.Value);  // TODO: Why the 8 ends up in the right child?! 
            }

        }

    }
}

