// This is the base class from which the cipher schemes inherit. All ciphers have an
// unenciphered "plain text" and an enciphered "cipher text" that is implemented here.
// It is common in the world of ciphers to eliminate characters such as spaces,
// punctuation, etc. from the text. Keeping these in can make it much easier to break the
// cipher. For instance, if you know that every sentence ends in a punctuation mark
// followed by a space, you've given yourself a big head start on cracking the code.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace simpleCiphers
{
    public abstract class cipher
    {
        // fields
        private string _plainText;
        private string _cipherText;


        // getters and setters
        public string PlainText
        {
            get
            {
                return this._plainText;
            }
            set
            {
                // convert user input to all uppercase and use regular expressions to
                // keep only uppercase letters and numbers from 0-9. Other chars may cause
                // challenges in enciphering and deciphering text if not eliminated

                _plainText = _plainText.ToUpper();
                _plainText = Regex.Replace(_plainText, @"[^A-Z0-9]", string.Empty);
            }
        }

        public string CipherText
        {
            get
            {
                return this._cipherText;
            }
            set
            {
                // convert user input to all uppercase and use regular expressions to
                // keep only uppercase letters and numbers from 0-9. Other chars may cause
                // challenges in enciphering and deciphering text if not eliminated

                _cipherText = _cipherText.ToUpper();
                _cipherText = Regex.Replace(_cipherText, @"[^A-Z0-9]", string.Empty);
            }
        }


        // constructors
        // not applicable to abstract class


        // methods
        // none at this time

    }
}
