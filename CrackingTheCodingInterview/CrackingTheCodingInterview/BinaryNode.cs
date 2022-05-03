using System;

namespace com.fabioscagliola.CrackingTheCodingInterview
{
    class BinaryNode<T> : BaseNode<T> where T : IComparable<T>
    {
        public BinaryNode<T> LChild { get; protected set; }

        public BinaryNode<T> RChild { get; protected set; }

        public BinaryNode(T value) : base(value) { }

        public BinaryNode(T value, BinaryNode<T> lChild) : base(value)
        {
            LChild = lChild;
        }

        public BinaryNode(T value, BinaryNode<T> lChild, BinaryNode<T> rChild) : this(value, lChild)
        {
            RChild = rChild;
        }

    }
}

