using System;

namespace TeamDemoALMDCNZ.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(1, 2));
            Console.WriteLine(Calculator.Subtract(5, 2));
            Console.WriteLine(Calculator.Multiply(8, 2));
            Console.WriteLine(Calculator.Divide(90, 3));
            Console.Read();
        }
    }
}
