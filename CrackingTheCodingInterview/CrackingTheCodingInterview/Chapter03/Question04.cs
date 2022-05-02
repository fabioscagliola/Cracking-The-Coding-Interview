using NUnit.Framework;
using System.Collections.Generic;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter03
{
    /// <summary>
    /// 
    /// ### 3.4 – Queue via Stacks 
    /// 
    /// Implement a `MyQueue` class which implements a queue using two stacks. 
    /// 
    /// </summary>
    class Question04
    {
        class QueueViaStacks<T>
        {
            readonly Stack<T> stack1;
            readonly Stack<T> stack2;

            public QueueViaStacks()
            {
                stack1 = new Stack<T>();
                stack2 = new Stack<T>();
            }

            public void Enqueue(T item)
            {
                while (stack1.Count != 0)
                {
                    stack2.Push(stack1.Pop());
                }

                stack1.Push(item);

                while (stack2.Count != 0)
                {
                    stack1.Push(stack2.Pop());
                }
            }

            public T Dequeue()
            {
                return stack1.Pop();
            }
        }

        [TestFixture]
        class Question04Test
        {
            [Test]
            public void Question04_QueueViaStacks_EnqueueAndDequeue()
            {
                QueueViaStacks<int> queueViaStacks = new QueueViaStacks<int>();
                queueViaStacks.Enqueue(1);
                queueViaStacks.Enqueue(9);
                queueViaStacks.Enqueue(7);
                queueViaStacks.Enqueue(5);
                queueViaStacks.Enqueue(0);
                queueViaStacks.Enqueue(1);
                queueViaStacks.Enqueue(2);
                queueViaStacks.Enqueue(3);
                Assert.AreEqual(1, queueViaStacks.Dequeue());
                Assert.AreEqual(9, queueViaStacks.Dequeue());
                Assert.AreEqual(7, queueViaStacks.Dequeue());
                Assert.AreEqual(5, queueViaStacks.Dequeue());
                Assert.AreEqual(0, queueViaStacks.Dequeue());
                Assert.AreEqual(1, queueViaStacks.Dequeue());
                Assert.AreEqual(2, queueViaStacks.Dequeue());
                Assert.AreEqual(3, queueViaStacks.Dequeue());
            }

        }

    }
}

