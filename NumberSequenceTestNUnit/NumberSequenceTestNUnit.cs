using NUnit.Framework;

namespace Exercices
{
    public class NumberSequenceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string sequence = "24541234";
            int maxSequence = NumberSequence.FindValue(sequence);
            Assert.IsTrue(maxSequence == 4);
        }

        [Test]
        public void Test2()
        {
            string sequence = "123765423754838338788";
            int maxSequence = NumberSequence.FindValue(sequence);
            Assert.IsTrue(maxSequence == 3);
        }
    }
}