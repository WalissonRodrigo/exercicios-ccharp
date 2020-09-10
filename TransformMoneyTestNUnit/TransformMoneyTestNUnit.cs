using NUnit.Framework;
using System;

namespace Exercices
{
    public class TransformMoneyTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string money = "10";
            double convert = TransformMoney.ConvertMoney(money);
            Console.WriteLine(convert);
            Assert.IsTrue(convert == 53.60);
        }

        [Test]
        public void Test2()
        {
            string money = "58";
            double convert = TransformMoney.ConvertMoney(money);
            Assert.IsTrue(convert == 310.88);
        }
    }
}