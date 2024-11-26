using Xunit;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddTest() => Assert.Equal(5, Calculator.Add(2, 3));

        [Fact]
        public void SubtractTest() => Assert.Equal(1, Calculator.Subtract(4, 3));

        [Fact]
        public void MultiplyTest() => Assert.Equal(12, Calculator.Multiply(4, 3));

        [Fact]
        public void DivideTest() => Assert.Equal(2, Calculator.Divide(6, 3));

        [Fact]
        public void DivideByZeroTest() =>
            Assert.Throws<System.DivideByZeroException>(() => Calculator.Divide(5, 0));
    }
}
