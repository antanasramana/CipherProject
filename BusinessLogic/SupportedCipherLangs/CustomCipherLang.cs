using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.SupportedCipherLangs
{
    /// <summary>
    /// Supports custom language alphabets. If english is only used it would be faster to implement the alphabet 
    /// using ASCII codes.
    /// </summary>
    public class CustomCipherLang : ICipherLanguage
    {
        // Stores the alphabet size in case the position specified is bigger than the actual alphabet size
        private readonly int _AlphabetSize;
        // Alphabet array to know what character is at what position
        private readonly char[] _AlphabetArray;
        // Alphabet map used to map characters to their positions in the alphabet
        private readonly IDictionary<char, int> _AlphabetMap;
        public CustomCipherLang(string alphabet)
        {
            if (alphabet != null)
            {
                this._AlphabetSize = alphabet.Length;
                this._AlphabetArray = alphabet.ToCharArray();
                this._AlphabetMap = new Dictionary<char, int>();
                for (int i = 0; i < this._AlphabetSize; i++)
                {
                    this._AlphabetMap.Add(new KeyValuePair<char, int>(this._AlphabetArray[i], i));
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public int GetAlphabetSize()
        {
            return this._AlphabetSize;
        }

        public char GetCharAtPosition(int position)
        {
            // Divides and gets the remainder, this is used if the position is specified bigger
            // than the actual size of the alphabet
            int positionInArray = position % _AlphabetSize;
            if (positionInArray >= 0)
            {
                return this._AlphabetArray[positionInArray];
            }
            else
            {
                return this._AlphabetArray[this._AlphabetSize + positionInArray];
            }
        }

        public int GetPositionOfChar(char symbol)
        {
            try
            {
                return this._AlphabetMap[char.ToLower(symbol)];
            }
            catch(KeyNotFoundException)
            {
                throw new ArgumentException("Specified symbol is not part of the alphabet");
            }
        }
    }
}
