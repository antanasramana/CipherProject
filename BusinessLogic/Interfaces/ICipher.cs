using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    /// <summary>
    /// Interface used to create different ciphers
    /// </summary>
    public interface ICipher
    {
        /// <summary>
        /// Ciphers provided text
        /// </summary>
        /// <param name="text">string of the text 
        /// that should be ciphered</param>
        /// <returns>Ciphered text</returns>
        string Cipher(string text);

        /// <summary>
        /// Deciphers provided text
        /// </summary>
        /// <param name="cipheredText">string of ciphered
        /// text that should be deciphered</param>
        /// <returns>Deciphered text</returns>
        string Decipher(string cipheredText);
    }
}
