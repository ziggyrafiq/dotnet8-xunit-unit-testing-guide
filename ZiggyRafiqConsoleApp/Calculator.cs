
namespace ZiggyRafiqConsoleApp
{
    public class Calculator : IDisposable
    {
        // Add method
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Subtract method
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Multiply method
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Divide method
        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }

            return (double)a / b;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose of managed resources here go here
                }

                // Dispose of unmanaged resources goes here , if any
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Calculator()
        {
            Dispose(false);
        }
    }


}
