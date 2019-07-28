// Transposition ciphers are ciphers in which the plaintext characters are changed.
// They are re-ordered in such a way as to "jumble the message".
// The following two lines are an example of this:
//
// Plain Text: IBM
// Enciphered Text: HAL
//
// These are relatively easy ciphers to break and aren't in use in situations that 
// truly require security.
//
// This is an abstract class that inherits from the cipher base class. It is just
// an 'abstraction layer' to help organize the code hierarchy.

using System;
using System.Collections.Generic;
using System.Text;

namespace simpleCiphers
{
    public abstract class substitutionCipher : cipher
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
