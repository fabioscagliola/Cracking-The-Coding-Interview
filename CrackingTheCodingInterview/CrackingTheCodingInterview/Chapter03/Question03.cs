using NUnit.Framework;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter03
{
    /// <summary>
    /// 
    /// ### 3.3 – Stack of Plates 
    /// 
    /// Imagine a (literal) stack of plates. If the stack gets too high, it might topple. Therefore, in real life, we would likely start a new stack when the previous stack exceeds some threshold. Implement a data structure `SetofStacks` that mimics this. `SetofStacks` should be composed of several stacks and should create a new stack once the previous one exceeds capacity. `SetofStacks.push()` and ?`SetofStacks.pop()` should behave identically to a single stack (that is, `pop()` should return the same values as it would if there were just a single stack). Implement a function `popAt(int index)` which performs a pop operation on a specific sub-stack. 
    /// 
    /// </summary>
    class Question03
    {
        static bool StackOfPlates(string s)
        {
            bool result = true;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        [TestFixture]
        class Question03Test
        {
            [Test]
            public void Question03_StackOfPlates_ReturnsFalse()
            {
                Assert.IsFalse(Question03.StackOfPlates("Laura"));
            }

            [Test]
            public void Question03_StackOfPlates_ReturnsTrue()
            {
                Assert.IsTrue(Question03.StackOfPlates("Fabio"));
            }

        }

    }
}

