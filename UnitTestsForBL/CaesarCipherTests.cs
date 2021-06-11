using BusinessLogic.Ciphers;
using BusinessLogic.SupportedCipherLangs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestsForBL
{
    [TestClass]
    public class CaesarCipherTests
    {
        [TestMethod]
        public void Cipher_Shift2English_ShouldCipherByShifting2()
        {
            int shift = 2;
            string textToCipher = "hello";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new EnglishCipherLang());

            string cipheredText = caesarCipher.Cipher(textToCipher);


            string expectedCipheredText = "jgnnq";

            Assert.AreEqual(expectedCipheredText, cipheredText);
        }
        [TestMethod]
        public void Cipher_ShiftMinus2English_ShouldCipherByShiftingMinus2()
        {
            int shift = -2;
            string textToCipher = "hello";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new EnglishCipherLang());

            string cipheredText = caesarCipher.Cipher(textToCipher);


            string expectedCipheredText = "fcjjm";

            Assert.AreEqual(expectedCipheredText, cipheredText);
        }
        [TestMethod]
        public void Cipher_Shift2CapitalLettersEnglish_ShouldCipherByShifting2PreserveCapitalLetters()
        {
            int shift = 2;
            string textToCipher = "HellO";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new EnglishCipherLang());

            string cipheredText = caesarCipher.Cipher(textToCipher);


            string expectedCipheredText = "JgnnQ";

            Assert.AreEqual(expectedCipheredText, cipheredText);
        }
        [TestMethod]
        public void Cipher_Shift2IgnoreCharsNotInEnglishAlphabet_ShouldCipherByShifting2IgnoreOtherChars()
        {
            int shift = 2;
            string textToCipher = "....HellO! ! !";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new EnglishCipherLang());

            string cipheredText = caesarCipher.Cipher(textToCipher);


            string expectedCipheredText = "....JgnnQ! ! !";

            Assert.AreEqual(expectedCipheredText, cipheredText);
        }
        [TestMethod]
        public void Cipher_ShiftBy90EnglishAlphabet_ShouldCipherByShifting90()
        {
            //90 is bigger than the size of the english alphabet, but that is not the problem
            //As the shifting happens in a cyclic manner
            int shift = 90;
            string textToCipher = "hello";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new EnglishCipherLang());

            string cipheredText = caesarCipher.Cipher(textToCipher);


            string expectedCipheredText = "tqxxa";

            Assert.AreEqual(expectedCipheredText, cipheredText);
        }

        [TestMethod]
        public void Cipher_ShiftByMinus80EnglishAlphabet_ShouldCipherByShiftingMinus80()
        {
            //-80 is bigger than the size of the english alphabet, but that is not the problem
            //As the shifting happens in a cyclic manner
            int shift = -80;
            string textToCipher = "hello";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new EnglishCipherLang());

            string cipheredText = caesarCipher.Cipher(textToCipher);


            string expectedCipheredText = "fcjjm";

            Assert.AreEqual(expectedCipheredText, cipheredText);
        }
        [TestMethod]
        public void Cipher_ShiftBy2LithuanianAlphabet_ShouldCipherByShifting2InLithuanian()
        {
            string lithuanianAlphabet = "aąbcčdeęėfghiįyjklmnoprsštuųūvzž";
            int shift = 2;
            string textToCipher = "Antanas!!";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new CustomCipherLang(lithuanianAlphabet));

            string cipheredText = caesarCipher.Cipher(textToCipher);


            string expectedCipheredText = "Bpųbpbt!!";

            Assert.AreEqual(expectedCipheredText, cipheredText);
        }
        [TestMethod]
        public void Cipher_ShiftByMinus4LithuanianAlphabet_ShouldCipherByShiftingMinus4InLithuanian()
        {
            string lithuanianAlphabet = "aąbcčdeęėfghiįyjklmnoprsštuųūvzž";
            int shift = -4;
            string textToCipher = "Antanas!!";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new CustomCipherLang(lithuanianAlphabet));

            string cipheredText = caesarCipher.Cipher(textToCipher);


            string expectedCipheredText = "Ūjpūjūn!!";

            Assert.AreEqual(expectedCipheredText, cipheredText);
        }
        [TestMethod]
        public void Cipher_ShiftBy70LithuanianAlphabet_ShouldCipherByShifting70InLithuanian()
        {
            string lithuanianAlphabet = "aąbcčdeęėfghiįyjklmnoprsštuųūvzž";
            int shift = 70;
            string textToCipher = "Antanas!!";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new CustomCipherLang(lithuanianAlphabet));

            string cipheredText = caesarCipher.Cipher(textToCipher);


            string expectedCipheredText = "Etžetev!!";

            Assert.AreEqual(expectedCipheredText, cipheredText);
        }

        [TestMethod]
        public void Decipher_ShiftBy2LithuanianAlphabet_ShouldDecipherByShift2InLithuanian()
        {
            string lithuanianAlphabet = "aąbcčdeęėfghiįyjklmnoprsštuųūvzž";
            int shift = 2;
            string textToDecipher = "Tžėymy!!";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new CustomCipherLang(lithuanianAlphabet));

            string cipheredText = caesarCipher.Decipher(textToDecipher);


            string expectedDecipheredText = "Sveiki!!";

            Assert.AreEqual(expectedDecipheredText, cipheredText);
        }
        [TestMethod]
        public void Decipher_ShiftBy70LithuanianAlphabet_ShouldDecipherByShifting70InLithuanian()
        {
            string lithuanianAlphabet = "aąbcčdeęėfghiįyjklmnoprsštuųūvzž";
            int shift = 70;
            string textToDecipher = "Etžetev!!";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new CustomCipherLang(lithuanianAlphabet));

            string cipheredText = caesarCipher.Decipher(textToDecipher);


            string expectedDecipheredText = "Antanas!!";

            Assert.AreEqual(expectedDecipheredText, cipheredText);
        }

        [TestMethod]
        public void Decipher_ShiftBy2EnglishAlphabet_ShouldDecipherByShifting2InEnglish()
        {
            int shift = 2;
            string textToDecipher = "JgnnQ.";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new EnglishCipherLang());

            string cipheredText = caesarCipher.Decipher(textToDecipher);


            string expectedDecipheredText = "HellO.";

            Assert.AreEqual(expectedDecipheredText, cipheredText);
        }

        [TestMethod]
        public void CipherAndDecipher_ShiftBy11LithuanianAlphabet_ShouldCipherAndDecipherByShifting11InLithuanian()
        {
            int shift = 11;
            string lithuanianAlphabet = "aąbcčdeęėfghiįyjklmnoprsštuųūvzž";
            string textToCipher = "Sveiki, mano vardas Antanas, mėgstu nardyti!";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new CustomCipherLang(lithuanianAlphabet));

            string cipheredText = caesarCipher.Cipher(textToCipher);
            string decipheredText = caesarCipher.Decipher(cipheredText);

            Assert.AreEqual(decipheredText, textToCipher);
        }

        [TestMethod]
        public void Cipher_ShiftBy2LithuanianAlphabetEmptyString_ShouldReturnEmptyString()
        {
            int shift = 11;
            string lithuanianAlphabet = "aąbcčdeęėfghiįyjklmnoprsštuųūvzž";
            string textToCipher = "";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new CustomCipherLang(lithuanianAlphabet));

            string cipheredText = caesarCipher.Cipher(textToCipher);
            

            Assert.AreEqual(textToCipher, cipheredText);
        }
        [TestMethod]
        public void Decipher_ShiftBy2LithuanianAlphabetEmptyString_ShouldReturnEmptyString()
        {
            int shift = 11;
            string lithuanianAlphabet = "aąbcčdeęėfghiįyjklmnoprsštuųūvzž";
            string textToDecipher = "";

            CaesarCipher caesarCipher = new CaesarCipher(shift, new CustomCipherLang(lithuanianAlphabet));

            string cipheredText = caesarCipher.Decipher(textToDecipher);


            Assert.AreEqual(textToDecipher, cipheredText);
        }
        [TestMethod]
        public void Cipher_ShiftBy2LithuanianAlphabetTextAsNull_ShouldThrowArgumentNullException()
        {
            int shift = 11;
            string lithuanianAlphabet = "aąbcčdeęėfghiįyjklmnoprsštuųūvzž";
            string textToDecipher = null;
            CaesarCipher caesarCipher = new CaesarCipher(shift, new CustomCipherLang(lithuanianAlphabet));

            Assert.ThrowsException<ArgumentNullException>(() => caesarCipher.Cipher(textToDecipher));
        }
        [TestMethod]
        public void Decipher_ShiftBy2LithuanianAlphabetTextAsNull_ShouldThrowArgumentNullException()
        {
            int shift = 11;
            string lithuanianAlphabet = "aąbcčdeęėfghiįyjklmnoprsštuųūvzž";
            string textToDecipher = null;
            CaesarCipher caesarCipher = new CaesarCipher(shift, new CustomCipherLang(lithuanianAlphabet));

            Assert.ThrowsException<ArgumentNullException>(() => caesarCipher.Decipher(textToDecipher));

        }

    }
}
