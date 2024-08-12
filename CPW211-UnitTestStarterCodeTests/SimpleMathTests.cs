using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            double expectedOutcome = num1 + num2;
            double returnedValue = SimpleMath.Add(num1, num2);
            Assert.AreEqual(expectedOutcome, returnedValue);
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(5, .5)]
        [DataRow(0, 0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double expectedOutcome = num1 * num2;
            double returnedValue = SimpleMath.Multiply(num1, num2);
            Assert.AreEqual(expectedOutcome, returnedValue);
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(5, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double invalidParam)
        {
            Assert.ThrowsException<ArgumentException>
                (() => SimpleMath.Divide(num1, invalidParam));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(5, .5)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        public void Divide_TwoValidNumbers_DividesSuccessfully(double num1, double num2)
        {
            double expectedOutcome = num1 / num2;
            double returnedValue = SimpleMath.Divide(num1, num2);
            Assert.AreEqual(expectedOutcome, returnedValue);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(5, .5)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        public void Subtract_TwoValidNumbers_SubtractsSuccessfully(double num1, double num2)
        {
            double expectedOutcome = num1 - num2;
            double returnedValue = SimpleMath.Subtract(num1, num2);
            Assert.AreEqual(expectedOutcome, returnedValue);
        }
    }
}