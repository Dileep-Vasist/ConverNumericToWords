using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericToWords;

namespace UnitTestProjectForNumericForWords
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ConvertNumberToWords_Should_Return_Numbers_In_Words()
        {
            //Arrange
            var mainType = new Program();
            int number = 13456;

            //Act
            string actual = mainType.ConvertNumberToWords(number);

            //Assert
            Assert.AreEqual("thirteen thousand four hundred fifty six", actual);
        }

        [TestMethod]
        public void ConvertNumberToWords_Should_Return_Numbers_In_Words_For_Numbers_Less_Than_Thousand_Value()
        {
            //Arrange
            var mainType = new Program();
            int number = 350;

            //Act
            string actual = mainType.ConvertNumberToWords(number);

            //Assert
            Assert.AreEqual("three hundred fifty", actual);
        }

        [TestMethod]
        public void ConvertNumberToWords_Should_Return_Numbers_In_Words_For_Numbers_Less_Than_Hundred_Value()
        {
            //Arrange
            var mainType = new Program();
            int number = 5;

            //Act
            string actual = mainType.ConvertNumberToWords(number);

            //Assert
            Assert.AreEqual("five", actual);
        }

        [TestMethod]
        public void ConvertNumberToWords_Should_Return_Numbers_In_Words_For_Two_Million()
        {
            //Arrange
            var mainType = new Program();
            int number = 2000000;

            //Act
            string actual = mainType.ConvertNumberToWords(number);

            //Assert
            Assert.AreEqual("two million", actual);
        }

        [TestMethod]
        public void ConvertNumberToWords_Should_Return_Numbers_In_Words_For_Negative_Numbers()
        {
            //Arrange
            var mainType = new Program();
            int number = -50;

            //Act
            string actual = mainType.ConvertNumberToWords(number);

            //Assert
            Assert.AreEqual("negative fifty", actual);
        }
    }
}
