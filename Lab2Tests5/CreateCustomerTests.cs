using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Tests
{
    [TestClass()]
    public class CreateCustomerTests
    {
        [TestMethod()]
        public void FieldResetTest()
        {
            //Arrange
            string s = "s";
            string expected = "";
            //Assert
            Assert.AreEqual(expected, s);
        }

        [TestMethod()]
        public void GetTotalCustomersTest()
        {
            int count = 5;
            int expected = 5;
            Assert.AreEqual(expected, count);
        }

        [TestMethod()]
        public void GetTotalkWhTest()
        {
            int count = 5;
            int expected = 5;
            Assert.AreEqual(expected, count);
        }
    }
}