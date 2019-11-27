using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace BusinessLogicTests
{
    [TestClass]
    public class ValidatorTest
    {
        private const int ssnMinLength = 9;

        [TestMethod]
        [DataRow("555-55-5555")]
        [DataRow("555555555")]
        [DataRow("547821693")]
        [DataRow("428-52-1234")]
        public void IsValidSsn_ValidInput_ReturnTrue(string input)
        {
            if (input.Contains("-"))
            {
                input.Replace("-", "");
            }
            bool isnum = input.All(char.IsDigit);
            Assert.IsTrue(input.Length == ssnMinLength && isnum == true);
        }

        [TestMethod]
        [DataRow("A")]
        [DataRow("123-123-123")]
        [DataRow("1234567890")]
        [DataRow("TenLetters")]
        public void IsValidSsn_InvalidInput_ReturnsFalse(string input)
        {
            if (input.Contains("-"))
            {
                input.Replace("-", "");
            }
            bool isnum = input.All(char.IsDigit);
            Assert.IsFalse(input.Length == ssnMinLength || isnum == false);
        }

        [TestMethod]
        [DataRow(10, 1, 10)] //max boundary
        [DataRow(1, 1, 10)] //min boundary
        [DataRow(5, 1, 10)]
        [DataRow(2000, 0, 50000)]
        public void IsWithinRange_NumInInclusiveRange_ReturnTrue(int test, int min, int max)
        {
            //If test is in Inclusive range
            Assert.IsTrue(test <= max && test >= min);
        }

        [TestMethod]
        [DataRow(4, 5, 10)]
        [DataRow(11, 1, 10)]
        [DataRow(10000, 0, 5000)]
        public void IsWithinRange_NumOutsideInclusiveRange_ReturnsFalse(int test, int min, int max)
        {
            //If test is out of Inclsive range
            Assert.IsFalse(test > min && test < max);
        }
    }
}
