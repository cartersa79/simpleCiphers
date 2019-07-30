// Technically, the Jefferson Wheel Cipher is a polyalphabetic substitution cipher. 
// I put it in the simple machine category because I've only ever seen actually
// used in a physical device. The original used 36 disks, each with the 26 letters
// of the alphabet randomly printed on the outside of the disk. The key is the order
// in which the disks are stacked. The sender and receiver must have them in the
// same order to successfully pass messages.
//
// To encipher, the sender spins the wheels until the desired message is shown. The
// sender then picks any of the other 25 rows to use as the enciphered message. To 
// decipher, the receiver reverses the process by spinning the wheels until the
// enciphered message is shown. The receiver then looks at the other 25 lines for a
// message that is readable.
//
// This implementation uses only one ordering of the disks. It can be expanded in the
// future to add the ability to change the ordering. It also only uses 10 wheels rather
// than TJ's original 36. It'd be easy enough to expand to 36.


using System;
using System.Collections.Generic;
using System.Text;

namespace simpleCiphers
{
    class jeffersonWheelCipher : simpleMachineCipher
    {

        // fields

        char[] w0 = { 'A', 'B', 'C', 'E', 'I', 'G', 'D', 'J', 'F', 'V', 'U', 'Y', 'M', 'H', 'T', 'Q', 'K', 'Z', 'O', 'L', 'R', 'X', 'S', 'P', 'W', 'N' };
        char[] w1 = { 'A', 'C', 'D', 'E', 'H', 'F', 'I', 'J', 'K', 'T', 'L', 'M', 'O', 'U', 'V', 'Y', 'G', 'Z', 'N', 'P', 'Q', 'X', 'R', 'W', 'S', 'B' };
        char[] w2 = { 'A', 'D', 'K', 'O', 'M', 'J', 'U', 'B', 'G', 'E', 'P', 'H', 'S', 'C', 'Z', 'I', 'N', 'X', 'F', 'Y', 'Q', 'R', 'T', 'V', 'W', 'L' };
        char[] w3 = { 'A', 'E', 'D', 'C', 'B', 'I', 'F', 'G', 'J', 'H', 'L', 'K', 'M', 'R', 'U', 'O', 'Q', 'V', 'P', 'T', 'N', 'W', 'Y', 'X', 'Z', 'S' };
        char[] w4 = { 'A', 'F', 'N', 'Q', 'U', 'K', 'D', 'O', 'P', 'I', 'T', 'J', 'B', 'R', 'H', 'C', 'Y', 'S', 'L', 'W', 'E', 'M', 'Z', 'V', 'X', 'G' };
        char[] w5 = { 'A', 'G', 'P', 'O', 'C', 'I', 'X', 'L', 'U', 'R', 'N', 'D', 'Y', 'Z', 'H', 'W', 'B', 'J', 'S', 'Q', 'F', 'K', 'V', 'M', 'E', 'T' };
        char[] w6 = { 'A', 'H', 'X', 'J', 'E', 'Z', 'B', 'N', 'I', 'K', 'P', 'V', 'R', 'O', 'G', 'S', 'Y', 'D', 'U', 'L', 'C', 'F', 'M', 'Q', 'T', 'W' };
        char[] w7 = { 'A', 'I', 'H', 'P', 'J', 'O', 'B', 'W', 'K', 'C', 'V', 'F', 'Z', 'L', 'Q', 'E', 'R', 'Y', 'N', 'S', 'U', 'M', 'G', 'T', 'D', 'X' };
        char[] w8 = { 'A', 'J', 'D', 'S', 'K', 'Q', 'O', 'I', 'V', 'T', 'Z', 'E', 'F', 'H', 'G', 'Y', 'U', 'N', 'L', 'P', 'M', 'B', 'X', 'W', 'C', 'R' };
        char[] w9 = { 'A', 'K', 'E', 'L', 'B', 'D', 'F', 'J', 'G', 'H', 'O', 'N', 'M', 'T', 'P', 'R', 'Q', 'S', 'V', 'Z', 'U', 'X', 'Y', 'W', 'I', 'C' };

        
       

        // getters and setters
        // default

        // constructors
        // default

        // methods


    }
}
