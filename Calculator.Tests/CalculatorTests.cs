using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Can_Add_Two_Numbers()
        {
            // Arrange
            var a = 1;
            var b = 2;
            var sut = new Core.Calculator();

            // Act
            var result = sut.Add(a, b);

            // Assert
            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        public void Can_Add_Two_Numbers_Data_Driven(int a, int b, int expectedResult)
        {
            // Arrange
            var sut = new Core.Calculator();

            // Act
            var actualResult = sut.Add(a, b);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
