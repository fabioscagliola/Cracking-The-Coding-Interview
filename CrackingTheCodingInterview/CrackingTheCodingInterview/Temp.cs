using NUnit.Framework;

namespace com.fabioscagliola.CrackingTheCodingInterview
{
    class Temp
    {
        static bool IsThisMyName(string name)
        {
            return name == "Fabio";
        }

        [TestFixture]
        class TempTest
        {
            [Test]
            public void Temp_IsThisMyName_ReturnsFalse()
            {
                Assert.IsFalse(Temp.IsThisMyName("Laura"));
            }

            [Test]
            public void Temp_IsThisMyName_ReturnsTrue()
            {
                Assert.IsTrue(Temp.IsThisMyName("Fabio"));
            }

        }

    }
}

