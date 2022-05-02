using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter03
{
    /// <summary>
    /// 
    /// ### 3.3 – Stack of Plates 
    /// 
    /// Imagine a (literal) stack of plates. If the stack gets too high, it might topple. Therefore, in real life, we would likely start a new stack when the previous stack exceeds some threshold. Implement a data structure `SetofStacks` that mimics this. `SetofStacks` should be composed of several stacks and should create a new stack once the previous one exceeds capacity. `SetofStacks.push()` and `SetofStacks.pop()` should behave identically to a single stack (that is, `pop()` should return the same values as it would if there were just a single stack). 
    /// 
    /// </summary>
    class Question03
    {
        class Stacks<T>
        {
            protected List<Stack<T>> stacks;

            protected int height;

            public Stacks(int height)
            {
                stacks = new();

                this.height = height;
            }

            public int NumberOfStacks { get { return stacks.Count; } }

            public void Push(T item)
            {
                if (stacks.Count == 0 || stacks[^1].Count == height)
                {
                    stacks.Add(new Stack<T>());
                }

                stacks[^1].Push(item);
            }

            public T Pop()
            {
                T item = stacks[^1].Pop();

                if (stacks[^1].Count == 0)
                {
                    stacks.Remove(stacks[^1]);
                }

                return item;
            }

        }

        [TestFixture]
        class Question03Test
        {
            [Test]
            public void Question03_Stacks_PushAndPop()
            {
                const int HEIGHT = 23;
                const int PLATES = 75;

                Stacks<int> stacks = new(HEIGHT);

                for (int i = 0; i < PLATES; i++)
                {
                    stacks.Push(i);
                    Assert.AreEqual(Math.Floor(i / HEIGHT + 1d), stacks.NumberOfStacks);
                }

                for (int i = 0; i < PLATES; i++)
                {
                    int test = stacks.Pop();
                    Assert.AreEqual(PLATES - 1 - i, test);
                    Assert.AreEqual(Math.Floor((PLATES - 1 - i) / HEIGHT + ((PLATES - 1 - i) % HEIGHT == 0 ? 0d : 1d)), stacks.NumberOfStacks);
                }
            }

        }

    }
}

