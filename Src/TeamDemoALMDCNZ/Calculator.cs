using TeamDemoALMDCNZ.Helper;

namespace TeamDemoALMDCNZ
{
    public class Calculator
    {
        /// <summary>
        /// Adds two values
        /// </summary>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts two values
        /// </summary>
        public static int Subtract(int a, int b)
        {
            return CalculatorHelper.SubtractHelper(a, b);
        }

        /// <summary>
        /// Multiplies two values
        /// </summary>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides two values
        /// </summary>
        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
