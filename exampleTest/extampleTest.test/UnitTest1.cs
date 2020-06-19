using System;
using System.CodeDom;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace extampleTest.test
{
    [TestClass]
    public class StringCalculatorshould
    {
        [TestMethod]
        public void Return_0_when_parameters_empty()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("");

            Assert.AreEqual(0, result);

        }
        [TestMethod]
        public void return_same_number() {

            var calculator = new StringCalculator();
            var result = calculator.Add("1");

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void return_result_suma() {

            var calculator = new StringCalculator();
            var result = calculator.Add("1,2");

            Assert.AreEqual(3, result);
        }
    }
     
}
