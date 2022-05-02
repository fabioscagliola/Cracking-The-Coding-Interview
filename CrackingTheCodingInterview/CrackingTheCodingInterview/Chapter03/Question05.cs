using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter03
{
    /// <summary>
    /// 
    /// ### 3.5 – Sort Stack 
    /// 
    /// Write a program to sort a stack such that the smallest items are on the top. You can use an additional temporary stack, but you may not copy the elements into any other data structure (such as an array). 
    /// 
    /// </summary>
    class Question05
    {
        static void SortStack<T>(Stack<T> stack) where T : IComparable<T>
        {
            stack.Sort();  // This extension method is implemented in Extensions.cs 
        }

        [TestFixture]
        class Question05Test
        {
            [Test]
            public void Question05_SortStack()
            {
                Stack<int> stack = new(new int[] { 1, 9, 7, 5, 0, 1, 2, 3 });
                Question05.SortStack(stack);
                CollectionAssert.AreEqual(new int[] { 0, 1, 1, 2, 3, 5, 7, 9 }, stack.ToArray());
            }

        }

    }
}

