
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NTW.Models;
using System;
using System.Collections.Generic;

namespace NTW.Tests 
{
    [TestClass]
    public class NumberTest
    {
        [TestMethod]
        public void NumberToWord_ReturnsWord_String()
        {
            string result = Number.NumberToWord(1);
            Assert.AreEqual(typeof(String), result.GetType());
        }

        [TestMethod]
        public void NumberToWord_ReturnsWord_LessTwenty()
        {
            string result = Number.NumberToWord(1);
            Assert.AreEqual("one", result);
        }
        [TestMethod]
        public void NumberToWord_ReturnsWord_MoreTwentyLessHundred()
        {
            string result = Number.NumberToWord(27);
            Assert.AreEqual("twenty seven", result);
        }
        [TestMethod]
        public void NumberToWord_ReturnsWord_MoreHundredLessThousand()
        {
            string result = Number.NumberToWord(456);
            Assert.AreEqual("four hundred fifty six", result);
        }
        [TestMethod]
        public void NumberToWord_ReturnsWord_MoreThousandLessMillion()
        {
            string result = Number.NumberToWord(456789);
            Assert.AreEqual("four hundred fifty six thousand seven hundred eighty nine", result);
        }
        [TestMethod]
        public void NumberToWord_ReturnsWord_MoreMillionLessBillion()
        {
            string result = Number.NumberToWord(123456789L);
            Assert.AreEqual("one hundred twenty three million four hundred fifty six thousand seven hundred eighty nine", result);
        }
        [TestMethod]
        public void NumberToWord_ReturnsWord_MoreBillionLessTrillion()
        {
            string result = Number.NumberToWord(456123456789L);
            Assert.AreEqual("four hundred fifty six billion one hundred twenty three million four hundred fifty six thousand seven hundred eighty nine", result);
        }
    }
}