namespace ZiggyRafiqConsoleApp
{
    public class CalculatorFixture : IDisposable
    {
        public Calculator Calculator { get; private set; }

        public CalculatorFixture()
        {
            // Initialize resources, create instances, etc.
            Calculator = new Calculator();
        }

        public void Dispose()
        {
            // Clean up resources, dispose of instances, etc.
            Calculator.Dispose();
        }
    }

}
