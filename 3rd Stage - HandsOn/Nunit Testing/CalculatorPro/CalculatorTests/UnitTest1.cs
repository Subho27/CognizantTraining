using System;
using System.Collections.Generic;
using NUnit.Framework;
namespace CalcLibrary
{
    [TestFixture]
    public class CalculatorTests
    {
        double result, Subresult, Mulresult, Divresult;
        [SetUp]
        public void SetUpMethod()
        {
            Subresult = 0;
            result=0;
            Mulresult = 0;
            Divresult = 0;
        }

        //ADD


        [Test]
        public void CalculatorAddMethod()
        {
            Calculator add = new Calculator();
            result = add.Addition(30, 70);
            Assert.That(result, Is.EqualTo(100));
        }
        [Test]
        [TestCase(20, 35, 55)]
        [TestCase(45, 50, 95)]

        public void CalculatorAddMethod(int x, int y, int expected)
        {
            Calculator add = new Calculator();
            result = add.Addition(x, y);
            Assert.AreEqual(expected, result);
        }
        
        //SUBSTRACT


        [Test]
        public void Calculatesubstract()
        {
            Calculator sub = new Calculator();
            result = sub.Subtraction(80, 60);
            Assert.AreEqual(20, result);
        }
        [Test]
        [TestCase(60, 40, 20)]
        [TestCase(10, 20, 10)]
        public void CalculatorSubParameter(int x, int y, int expected)
        {
            Calculator sub = new Calculator();
            Subresult = sub.Subtraction(x, y);
            Assert.AreEqual(expected, Subresult);
        }

        //MULTIPLICATION


        [Test]
        public void CalculateMultiplication()
        {
            Calculator mul = new Calculator();
            Mulresult = mul.Multiplication(4, 6);
            Assert.AreEqual(24, Mulresult);
        }
        [Test]
        [TestCase(8, 9, 72)]
        [TestCase(9, 4, 36)]
        public void CalculatorMulParameter(int x, int y, int expected)
        {
            Calculator mul = new Calculator();
            Mulresult = mul.Multiplication(x, y);
            Assert.AreEqual(expected, Mulresult);
        }

        //DIVISION

        [Test]
        public void CalculateDivision()
        {
            Calculator div = new Calculator();
            Divresult = div.Division(24, 6);
            Assert.AreEqual(4, Divresult);
        }
        [Test]
        [TestCase(27, 3, 9)]
        [TestCase(8, 0, 0)]
        public void CalculatorDivParameter(int x, int y, int expected)
        {
            Calculator div = new Calculator();
            try
            {
                    Divresult = div.Division(x, y);
                    Assert.AreEqual(expected, Divresult);
                
            }
            catch (ArgumentException)
            {

                Assert.Fail("Division by zero");

            }
        }

        [Test]
        public void TestAddAndClear()
        {
            Calculator add = new Calculator();
            result = add.Addition(40, 20);
            Assert.That(result, Is.EqualTo(60));
            add.AllClear();
            result = add.GetResult;
            Assert.AreEqual(0, result);

        }


        [TearDown]
        public void CleanUpMethod()
        {
            Subresult = 0;
            result = 0;
            Mulresult = 0;
            Divresult = 0;
        }
    }
}