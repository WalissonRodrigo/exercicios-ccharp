using FastFood;
using NUnit.Framework;

namespace Exercices
{
    public class FastFoodTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSumAllItems()
        {
            int snack = 1, soda = 1, fries = 1;
            Request request = new Request();
            request.Products.Add(new ProductMeat(snack));
            request.Products.Add(new ProductChicken(snack));
            request.Products.Add(new ProductSalad(snack));
            request.Products.Add(new ProductMayonnaise(snack));
            request.Products.Add(new ProductFries(fries));
            request.Products.Add(new ProductSoda(soda));
            double totalRequest = request.TotalRequest();
            Assert.IsTrue(totalRequest == 49);
        }

        [Test]
        public void Test1()
        {
            string RequestString = "1 hamburguer de carne com salada e 2 refrigerantes";
            Request request1 = Request.TranslateRequest(RequestString);
            Assert.IsTrue(request1.TotalRequest() == 30);
        }

        [Test]
        public void Test2()
        {
            string RequestString = "2 hamburguer de carne sem salada, 2 batatas fritas com maionese e 1 refrigerante";
            Request request1 = Request.TranslateRequest(RequestString);
            Assert.IsTrue(request1.TotalRequest() == 58);
        }
    }
}