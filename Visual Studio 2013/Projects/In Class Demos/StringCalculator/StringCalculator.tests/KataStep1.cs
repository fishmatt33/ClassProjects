using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalculator.tests
{
    [TestFixture]
    public class KataStep1
    {
        public void Empty_string_should_return_zero()
        {
            // arrange
            Calculator calc = new Calculator();
            
            //act
            int result = calc.Add("");
            
            // assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void One_number_should_return_itself()
        {

            // Arrange
            Calculator myCalc = new Calculator();

            // Act
            int result = myCalc.Add("1");

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void two_numbers_should_return_sum()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            int result = calc.Add("1,2");

            //Asset
            Assert.AreEqual(3, result);
        }
    }
}
