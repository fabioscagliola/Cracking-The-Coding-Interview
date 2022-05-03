using System;
using System.Collections.Generic;

namespace com.fabioscagliola.CrackingTheCodingInterview
{
    class Graph<T> where T : IComparable<T>
    {
        public List<Node<T>> NodeList { get; set; }

        public Graph()
        {
            NodeList = new();
        }

        public Node<T> DepthFirstSearch(Node<T> source, Node<T> target)
        {
            return source.DepthFirstSearch(target);
        }

    }
}

