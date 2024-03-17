namespace ZiggyRafiqConsoleApp.Tests
{
    public class CalculatorTests : IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture _fixture;

        public CalculatorTests(CalculatorFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void TestAddition()
        {
            // Arrange
            Calculator calculator = _fixture.Calculator;
            int a = 5;
            int b = 10;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.Equal(15, result);
        }
    }

}
