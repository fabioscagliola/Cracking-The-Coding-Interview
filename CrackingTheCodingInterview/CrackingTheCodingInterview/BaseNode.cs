using System;

namespace com.fabioscagliola.CrackingTheCodingInterview
{
    abstract class BaseNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }

        public bool Visited { get; set; }

        public BaseNode(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

    }
}

