// Transposition ciphers are ciphers in which none of the plaintext characters
// are changed, they are just re-ordered in such a way as to "jumble the message".
// The following two lines are an example of this:
//
// Plain Text: CSC260WASAGREATCLASS
// Enciphered Text: SSALCTAERGASAW062CSC
//
// This is a super easy cipher that nobody (except little kids) would ever
// use. It is just the plain text string reversed. All you have to do to 
// decipher is read from right to left. 
//
// This is an abstract class that inherits from the cipher base class. It is just
// an 'abstraction layer' to help organize the code hierarchy. It doesn't implement
// anything.

using System;
using System.Collections.Generic;
using System.Text;

namespace simpleCiphers
{
    public abstract class transpositionCipher : cipher
    {
        // fields
        // none

        // getters and setters
        // none

        // constructors
        // not applicable to abstract class

        // methods
        // none
    }
}
