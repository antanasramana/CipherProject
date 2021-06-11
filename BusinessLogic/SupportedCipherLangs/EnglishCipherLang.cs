using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
namespace BusinessLogic.SupportedCipherLangs
{
    /// <summary>
    /// English alphabet calculated from ASCII codes. Faster implementation
    /// Than the custom cipher language.
    /// </summary>
    public class EnglishCipherLang : ICipherLanguage
    {
        private readonly int _AlphabetSize;
        public EnglishCipherLang()
        {
            _AlphabetSize = 26;
        }
        public int GetAlphabetSize()
        {
            return _AlphabetSize;
        }

        public char GetCharAtPosition(int position)
        {
            int positionInAlphabet = position % _AlphabetSize;
            if (positionInAlphabet >= 0)
            {
                // 97 is the starting code of a in the ASCII table
                return (char)(97 + positionInAlphabet);
            }
            else
            {
                // 123 is the code of character after the z in the ASCII table
                return (char)(123 + positionInAlphabet);
            }
        }

        public int GetPositionOfChar(char symbol)
        {
            int position = (int)char.ToLower(symbol);
            if (position >= 97 && position <= 122)
            {
                return position - 97;
            }
            else
            {
                throw new ArgumentException("Specified symbol is not part of the alphabet");
            }
        }
    }
}
