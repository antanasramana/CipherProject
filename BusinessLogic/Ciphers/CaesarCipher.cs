using BusinessLogic.Interfaces;
using System;
using System.Text.RegularExpressions;

namespace BusinessLogic.Ciphers
{
    public class CaesarCipher : ICipher
    {
        public int Shift { get; private set; }
        public ICipherLanguage CipherLanguage { get; private set; }

        public CaesarCipher(int shift, ICipherLanguage cipherLanguage)
        {
            this.Shift = shift;
            if (cipherLanguage != null)
            {
                this.CipherLanguage = cipherLanguage;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
        public string Cipher(string text)
        {
            if (text != null)
            {
                string cipheredText = "";
                foreach (char symbol in text)
                {
                    try
                    {
                        char cipheredSymbol = Cipher(symbol);
                        //Checks whether the original text character was in upper case
                        if (char.IsUpper(symbol))
                        {
                            //If the previous character was in upper case it uppercases the encrypted character as well
                            cipheredSymbol = char.ToUpper(cipheredSymbol);
                        }

                        cipheredText += cipheredSymbol;
                    }
                    catch (ArgumentException)
                    {
                        cipheredText += symbol;
                    }
                }
                return cipheredText;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        private char Cipher(char symbol)
        {
            return CipherLanguage.GetCharAtPosition(
                   CipherLanguage.GetPositionOfChar(symbol) + this.Shift);
        }

        public string Decipher(string cipheredText)
        {
            if (cipheredText != null)
            {
                string decipheredText = "";
                foreach (char symbol in cipheredText)
                {
                    try
                    {
                        char decipheredSymbol = Decipher(symbol);

                        //Checks whether the original text character was in upper case
                        if (char.IsUpper(symbol))
                        {
                            //If the previous character was in upper case it uppercases the decrypted character as well
                            decipheredSymbol = char.ToUpper(decipheredSymbol);
                        }

                        decipheredText += decipheredSymbol;
                    }
                    catch (ArgumentException)
                    {
                        decipheredText += symbol;
                    }
                }
                return decipheredText;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        private char Decipher(char cipheredSymbol)
        {
            return CipherLanguage.GetCharAtPosition(
                   CipherLanguage.GetPositionOfChar(cipheredSymbol) - this.Shift);
        }
    }
}
