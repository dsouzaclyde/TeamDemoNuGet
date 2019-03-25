using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamDemoALMDCNZ.Helper;

namespace TeamDemoALMDCNZ.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Test()
        {
            var x = Calculator.Add(1, 2);
            Assert.AreEqual(3, x);
        }

        [TestMethod]
        public void SubtractHelper_Test()
        {
            var x = CalculatorHelper.SubtractHelper(5, 3);
            Assert.AreEqual(2, x);
        }

        [TestMethod]
        public void Subtract_Test()
        {
            var x = Calculator.Subtract(5, 3);
            Assert.AreEqual(2, x);
        }

        [TestMethod]
        public void Multiply_Test()
        {
            var x = Calculator.Multiply(5, 3);
            Assert.AreEqual(15, x);
        }

        [TestMethod]
        public void Divide_Test()
        {
            var x = Calculator.Divide(60, 3);
            Assert.AreEqual(20, x);
        }
    }
}
