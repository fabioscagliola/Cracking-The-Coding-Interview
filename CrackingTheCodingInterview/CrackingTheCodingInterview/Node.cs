using System;
using System.Collections.Generic;

namespace com.fabioscagliola.CrackingTheCodingInterview
{
    class Node<T> : BaseNode<T> where T : IComparable<T>
    {
        public List<Node<T>> NodeList { get; set; }

        public Node(T value) : base(value)
        {
            NodeList = new();
        }

        public Node<T> DepthFirstSearch(Node<T> target)
        {
            Visited = true;

            foreach (Node<T> node in NodeList)
            {
                if (!node.Visited && node.Value.Equals(target.Value))
                {
                    return node;
                }

                Node<T> result = node.DepthFirstSearch(target);

                if (result != null)
                {
                    return result;
                }
            }

            return null;
        }

    }
}

