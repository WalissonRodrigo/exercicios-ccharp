using NUnit.Framework;

namespace Exercices
{
    public class SequenceGolombTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int n = 3;
            string expected = "1, 2, 2";
            string golomb = SequenceGolomb.GenerateGolomb(n);

            Assert.IsTrue(SequenceGolomb.GenerateGolomb(n) == expected);
        }

        [Test]
        public void Test2()
        {
            int n = 10;
            string expected = "1, 2, 2, 3, 3, 4, 4, 4, 5, 5";
            Assert.IsTrue(SequenceGolomb.GenerateGolomb(n) == expected);
        }
    }
}