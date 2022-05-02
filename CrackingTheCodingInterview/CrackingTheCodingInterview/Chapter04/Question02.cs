using NUnit.Framework;
using System;

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
        static Node<T> MinimalTree<T>(T[] list) where T : IComparable<T>
        {
            Node<T> parent = new(list[0]);

            for (int i = 1; i < list.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    parent.NodeList.Add(new Node<T>(list[i]));
                }
            }

            return parent;
        }

        [TestFixture]
        class Question02Test
        {
            [Test]
            public void Question02_MinimalTree()
            {
                Graph<int> graph = new();

                Node<int> n0 = new(0);
                Node<int> n1 = new(1);
                Node<int> n2 = new(2);
                Node<int> n3 = new(3);
                Node<int> n4 = new(4);
                Node<int> n5 = new(5);

                n0.NodeList.Add(n1);
                n0.NodeList.Add(n4);
                n0.NodeList.Add(n5);

                n1.NodeList.Add(n3);
                n1.NodeList.Add(n4);

                n2.NodeList.Add(n1);

                n3.NodeList.Add(n2);
                n3.NodeList.Add(n4);

                graph.NodeList.Add(n0);
                graph.NodeList.Add(n1);
                graph.NodeList.Add(n2);
                graph.NodeList.Add(n3);
                graph.NodeList.Add(n4);
                graph.NodeList.Add(n5);

                Node<int> node = MinimalTree(new int[] { 0, 1, 2, 3, 5, 7, 9 });
            }

        }

    }
}

