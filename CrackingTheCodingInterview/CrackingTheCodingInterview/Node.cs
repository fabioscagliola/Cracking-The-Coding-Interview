using System;
using System.Collections.Generic;

namespace com.fabioscagliola.CrackingTheCodingInterview
{
    class Node<T> where T : IComparable<T>
    {
        public List<Node<T>> NodeList { get; set; }

        public T Value { get; set; }

        public bool Visited { get; set; }

        public Node(T value)
        {
            NodeList = new();

            Value = value;
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

                node.DepthFirstSearch(target);
            }

            return null;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

    }
}

