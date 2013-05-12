using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using amcp_0003_Square_Csharp;

namespace UnitTestCsharp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSquare_input_is_5()
        {
            Square s = new Square();
            int number = 5;
            int result = Square.square(number);
            int expected = 25;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSquare_input_is_3()
        {
            Square s = new Square();
            int number = 3;
            int result = Square.square(number);
            int expected = 9;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSquare_input_is_1()
        {
            Square s = new Square();
            int number = 1;
            int result = Square.square(number);
            int expected = 1;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSquare_input_is_zero()
        {
            Square s = new Square();
            int number = 0;
            int result = Square.square(number);
            int expected = 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSquare_input_is_minus_1()
        {
            Square s = new Square();
            int number = -1;
            int result = Square.square(number);
            int expected = 1;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSquare_input_is_minus_5()
        {
            Square s = new Square();
            int number = -5;
            int result = Square.square(number);
            int expected = 25;
            Assert.AreEqual(expected, result);
        }
    }
}
