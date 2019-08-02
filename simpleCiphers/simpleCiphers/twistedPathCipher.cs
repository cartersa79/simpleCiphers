//A twisted path cipher is a type of transposition cipher.The general idea is to encipher
// by filling a 2-D array with the plain text message and then follow the diagonals, right-to-left,
// bottom-right to top-left, etc to re-write the message into an enciphered text.The following
// is an example of bottom-right up to top-left.

// Plain text: CSC260WASAGREATCLASS

//   C S C 2 6 0 W
//   A S A G R E A
//   T C L A S S X

// Enciphered text: XAWSE0SR6AG2LACCSSTAC

// As can be seen, there are a huge number of variations that can be derived in this method.


// TODO: I'm not going to get to this one for the project. Since this one has so many variations
// I think it would be fun to implement graphically.I think it would be best served with a GUI
// to select the path order.That is more work than I can handle for this project...it has been a
// busy semester.

using System;
using System.Collections.Generic;
using System.Text;

namespace simpleCiphers
{
    public class twistedPathCipher : transpositionCipher
    {
        // TODO: All of it
    }
}
