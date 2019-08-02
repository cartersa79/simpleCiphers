// Substitution ciphers are ciphers in which the plaintext characters are changed
// but their order stays the same The following two lines are an example of this
// where the letters are just each shifted back by 1. Are you a Stanley Kubrick fan?
//
// Plain Text: IBM
// Enciphered Text: HAL
//
// These are relatively easy ciphers to break and aren't in use in situations that 
// truly require security. There are lots of varieties of these and some can be
// difficult to break with paper and pencil but generally pretty easy with a computer.
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
