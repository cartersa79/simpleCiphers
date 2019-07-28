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
        private string _plainText { get; set; }
        private string _cipherText { get; set; }


        // getters and setters
        // used default        
        
        
        // constructors
        // not applicable to abstract class


        // methods
        public virtual string cleanText(string inputText)
        {
            inputText = inputText.ToUpper();
            inputText = Regex.Replace(inputText, @"[^A-Z0-9]", string.Empty);

            return inputText;
        }

    }
}
