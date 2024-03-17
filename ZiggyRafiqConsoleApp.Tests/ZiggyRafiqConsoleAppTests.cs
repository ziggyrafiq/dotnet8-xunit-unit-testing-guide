namespace ZiggyRafiqConsoleApp.Tests
{
    public class ZiggyRafiqConsoleAppTests
    {
        [Fact]
        public void TestAddition()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = a + b;

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestSubtraction()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = a - b;

            // Assert
            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(5, 4, 20)]
        [InlineData(0, 7, 0)]
        public void TestMultiplication(int a, int b, int expected)
        {
            // Act
            int result = a * b;

            // Assert
            Assert.Equal(expected, result);
        }
    }


}


