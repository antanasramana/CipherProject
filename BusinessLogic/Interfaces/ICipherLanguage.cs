using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    /// <summary>
    /// Used to implement different languages that work on ciphers.
    /// </summary>
    public interface ICipherLanguage
    {
        /// <summary>
        /// Gets the Character at the specified position
        /// in the alphabet
        /// </summary>
        /// <param name="position">Position of the alphabet</param>
        /// <returns>Character at the specified position in the alphabet</returns>
        char GetCharAtPosition(int position);
        /// <summary>
        /// Gets the position of the specified character in the alphabet
        /// </summary>
        /// <param name="symbol">Character to look for in the alphabet</param>
        /// <returns>Position of the specified character in the alphabet</returns>
        int GetPositionOfChar(char symbol);

        /// <summary>
        /// Gets the alphabet size of current language
        /// </summary>
        /// <returns>size of the current languages alphabet</returns>
        int GetAlphabetSize();
    }
}
