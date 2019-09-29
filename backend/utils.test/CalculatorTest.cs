using NUnit.Framework;
using utils;

namespace Tests
{
    public class CalculatorTest
    {
        [Test]
        public void TestAddTwoNumbers()
        {
            Assert.AreEqual(5, new Calculator().Add(2, 3));
        }
    }
}