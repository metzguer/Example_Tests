using System;
using libraryTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LensDistanceTests
{
    [TestClass]
    public class DistanceLewhenstein
    {
        [TestMethod]
        public void XamarinAdnCamarinShouldReturn()
        {
            //arrange
            var cadena1 = "Xamarin";
            var cadena2 = "camarin"; 
            var resultado = 1;

            var distance = new LevenDistance();
            //execute-action
            var c = distance.Compute(cadena1, cadena2);

            //Asserts
            Assert.AreEqual(resultado, c);
        }
    }
}
