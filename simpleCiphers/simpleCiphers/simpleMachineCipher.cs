// Machine ciphers are ciphers that use some sort of device to encipher and decipher
// text. Perhaps the most famous is the secret decoder ring from a box of cereal or
// perhaps the Enigma device used by the Nazis during WWII. These devices can have
// codes that are simple to break or codes that are incredibly difficult to crack.
//
// This is an abstract class that inherits from the cipher base class. It is just
// an 'abstraction layer' to help organize the code hierarchy. It doesn't implement
// anything.

using System;
using System.Collections.Generic;
using System.Text;

namespace simpleCiphers
{
    class simpleMachineCipher : cipher
    {
    }
}
