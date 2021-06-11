using BusinessLogic.SupportedCipherLangs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestsForBL
{
    [TestClass]
    public class CipherLangsTest
    {
        [TestMethod]
        public void GetCharAt18_EnglishAlphabet_ShouldReturn_s()
        {
            int position = 18;
            char expectedChar = 's';

            EnglishCipherLang englishCipherLang = new EnglishCipherLang();
            char actualChar = englishCipherLang.GetCharAtPosition(position);

            Assert.AreEqual(expectedChar, actualChar);
        }
        [TestMethod]
        public void GetCharAtMinus2_EnglishAlphabet_ShouldReturn_y()
        {
            int position = -2;
            char expectedChar = 'y';

            EnglishCipherLang englishCipherLang = new EnglishCipherLang();
            char actualChar = englishCipherLang.GetCharAtPosition(position);

            Assert.AreEqual(expectedChar, actualChar);
        }
        [TestMethod]
        public void GetCharAt80_EnglishAlphabet_ShouldReturn_y()
        {
            int position = 80;
            char expectedChar = 'c';

            EnglishCipherLang englishCipherLang = new EnglishCipherLang();
            char actualChar = englishCipherLang.GetCharAtPosition(position);

            Assert.AreEqual(expectedChar, actualChar);
        }
        [TestMethod]
        public void GetCharAt28_LithuanianAlphabet_ShouldReturn_ū()
        {
            int position = 28;
            char expectedChar = 'ū';

            CustomCipherLang customCipherLang = new CustomCipherLang("aąbcčdeęėfghiįyjklmnoprsštuųūvzž");
            char actualChar = customCipherLang.GetCharAtPosition(position);

            Assert.AreEqual(expectedChar, actualChar);
        }
        [TestMethod]
        public void GetCharAtMinus15_LithuanianAlphabet_ShouldReturn_l()
        {
            int position = -15;
            char expectedChar = 'l';

            CustomCipherLang customCipherLang = new CustomCipherLang("aąbcčdeęėfghiįyjklmnoprsštuųūvzž");
            char actualChar = customCipherLang.GetCharAtPosition(position);

            Assert.AreEqual(expectedChar, actualChar);
        }
        [TestMethod]
        public void GetCharAt92_LithuanianAlphabet_ShouldReturn_ū()
        {
            int position = 92;
            char expectedChar = 'ū';

            CustomCipherLang customCipherLang = new CustomCipherLang("aąbcčdeęėfghiįyjklmnoprsštuųūvzž");
            char actualChar = customCipherLang.GetCharAtPosition(position);

            Assert.AreEqual(expectedChar, actualChar);
        }
        [TestMethod]
        public void GetPosOfCharC_LithuanianAlphabet_ShouldReturn_3()
        {
            char symbol = 'C';
            int expectedPosition = 3;

            CustomCipherLang customCipherLang = new CustomCipherLang("aąbcčdeęėfghiįyjklmnoprsštuųūvzž");
            int actualPosition = customCipherLang.GetPositionOfChar(symbol);

            Assert.AreEqual(expectedPosition, actualPosition);
        }
        [TestMethod]
        public void GetPosOfCharC_EnglishAlphabet_ShouldReturn_2()
        {
            char symbol = 'C';
            int expectedPosition = 2;

            EnglishCipherLang englishCipherLang = new EnglishCipherLang();
            int actualPosition = englishCipherLang.GetPositionOfChar(symbol);

            Assert.AreEqual(expectedPosition, actualPosition);
        }
        [TestMethod]
        public void GetPosOfCharū_LithuanianAlphabet_ShouldReturn_28()
        {
            char symbol = 'ū';
            int expectedPosition = 28;

            CustomCipherLang customCipherLang = new CustomCipherLang("aąbcčdeęėfghiįyjklmnoprsštuųūvzž");
            int actualPosition = customCipherLang.GetPositionOfChar(symbol);

            Assert.AreEqual(expectedPosition, actualPosition);
        }
        [TestMethod]
        public void GetPosOfĄ_EnglishAlphabet_ShouldThrowArgumentException()
        {
            char symbol = 'Ą';
            EnglishCipherLang englishCipherLang = new EnglishCipherLang();
            Assert.ThrowsException<ArgumentException>(() => englishCipherLang.GetPositionOfChar(symbol));
        }
        [TestMethod]
        public void GetPosOfSpecialChar_LithuanianhAlphabet_ShouldThrowArgumentException()
        {
            char symbol = '/';
            CustomCipherLang customCipherLang = new CustomCipherLang("aąbcčdeęėfghiįyjklmnoprsštuųūvzž");
            Assert.ThrowsException<ArgumentException>(() => customCipherLang.GetPositionOfChar(symbol));
        }

    }
}
