using NUnit.Framework;
using System;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter04
{
    /// <summary>
    /// 
    /// ### 4.1 Route Between Nodes 
    /// 
    /// Given a directed graph and two nodes (S and E), design an algorithm to find out whether there is a route from S to E. 
    /// 
    /// </summary>
    class Question01
    {
        static bool RouteBetweenNodes<T>(Graph<T> graph, Node<T> source, Node<T> target) where T : IComparable<T>
        {
            return graph.DepthFirstSearch(source, target) != null;
        }

        [TestFixture]
        class Question01Test
        {
            [Test]
            public void Question01_RouteBetweenNodes()
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

                Assert.IsTrue(RouteBetweenNodes(graph, n0, n1));
                //Assert.IsNotNull(graph.DepthFirstSearch(n0, n2));
                //Assert.IsNotNull(graph.DepthFirstSearch(n0, n3));
                //Assert.IsNotNull(graph.DepthFirstSearch(n0, n4));
                //Assert.IsNotNull(graph.DepthFirstSearch(n0, n5));
                //Assert.IsNull(graph.DepthFirstSearch(n1, n0));
                //Assert.IsNull(graph.DepthFirstSearch(n1, n2));
                //Assert.IsNotNull(graph.DepthFirstSearch(n1, n3));
                //Assert.IsNotNull(graph.DepthFirstSearch(n1, n4));
                //Assert.IsNull(graph.DepthFirstSearch(n1, n5));
                //Assert.IsNull(graph.DepthFirstSearch(n2, n0));
                //Assert.IsNotNull(graph.DepthFirstSearch(n2, n1));
                //Assert.IsNotNull(graph.DepthFirstSearch(n2, n3));
                //Assert.IsNotNull(graph.DepthFirstSearch(n2, n4));
                //Assert.IsNull(graph.DepthFirstSearch(n2, n5));
                //Assert.IsNull(graph.DepthFirstSearch(n3, n0));
                //Assert.IsNotNull(graph.DepthFirstSearch(n3, n1));
                //Assert.IsNotNull(graph.DepthFirstSearch(n3, n2));
                //Assert.IsNotNull(graph.DepthFirstSearch(n3, n4));
                //Assert.IsNull(graph.DepthFirstSearch(n3, n5));
                //Assert.IsNull(graph.DepthFirstSearch(n4, n0));
                //Assert.IsNull(graph.DepthFirstSearch(n4, n1));
                //Assert.IsNull(graph.DepthFirstSearch(n4, n2));
                //Assert.IsNull(graph.DepthFirstSearch(n4, n3));
                //Assert.IsNull(graph.DepthFirstSearch(n4, n5));
                //Assert.IsNull(graph.DepthFirstSearch(n5, n0));
                //Assert.IsNull(graph.DepthFirstSearch(n5, n1));
                //Assert.IsNull(graph.DepthFirstSearch(n5, n2));
                //Assert.IsNull(graph.DepthFirstSearch(n5, n3));
                //Assert.IsNull(graph.DepthFirstSearch(n5, n4));
            }

        }

    }
}

