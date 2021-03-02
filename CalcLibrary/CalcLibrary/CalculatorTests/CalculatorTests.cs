using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalcLibrary;

namespace CalculatorTests
{
    [TestFixture]
    class CalculatorTests
    {
        
        SimpleCalculator calc;
        [SetUp]
        public void SetUp()
        {
            calc = new SimpleCalculator();
        
        }
        [Test]
        [TestCase(10,20,30)]
        public void CalculateAdd(double a, double b,double expected)
        {
            
            double actual = calc.Addition(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        [TestCase(20,10,10)]
        [TestCase(70,20,50)]
        [TestCase(10, 20, -10)]
        public void CalculateSub(double a,double b,double expected)
        {
            
            double actual = calc.Subtraction(a, b);
            Assert.AreEqual(actual, expected);
        }
        [Test]
        [TestCase(20,10,200)]
        [TestCase(75, 5, 375)]
        [TestCase(6, 16, 96)]
        public void CalculateMultiply(double a,double b,double expected)
        {
           
            double actual = calc.Multiplication(a, b);
            Assert.AreEqual(actual, expected);
        }
        [Test]
        [TestCase(10,2,5)]
        [TestCase(20,20,1)]
        [TestCase(45,0,0)]
        public void CalculateDivision(double a,double b,double expected)
        {
            
            try
            {
                double actual = calc.Division(a, b);
                Assert.AreEqual(actual, expected);
            }
            catch
            {
                Assert.Fail("Division by zero");
            }
            
        }
        [Test]
        [TestCase(50,70,120)]
        public void AddAndClear(double a,double b,double expected)
        {
            
            calc.Addition(a, b);
            Assert.AreEqual(calc.GetResult, expected);
            calc.AllClear();
            Assert.AreEqual(calc.GetResult, 0);
        }
        [TearDown]
        public void CleanUpMethod()
        {
            
            calc = null;
        }
    }
}
