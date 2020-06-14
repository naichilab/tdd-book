using System;
using Xunit;

namespace MoneyExampleTest
{
    public class MoneyTest
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = Dollar(5);
            five.Times(2);
            Assert.Equal(10, five.Amount);
        }
    }
}