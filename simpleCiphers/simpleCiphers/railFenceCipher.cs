// Rail Fence Ciphers are a type of transposition ciphers. The plaintext characters
// are re-ordered in such a way as to "jumble the message". With this particular,
// you decide how many rails are on the fence and just write every letter of the
// plain text in a diagonal pattern. The resulting rows are your enciphered text.
// The following is an example of A 3 rail fence cipher. It is easy to read, just
// read diagonally down, then up, etc.
//
// Plain Text: CSC260WASAGREATCLASS
//
//    C   6   S   E   L
//     S 2 0 A A R A C A S
//      C   W   G   T   S
//
// Enciphered Text: C6SELS20AARACASCWGTS
//
// This cipher is a pretty easy cipher to break but it requires some work. Most people
// can't just look at it and break the code. It usually requires a pencil and paper
// (or handy dandy developer to write a program) to read.


using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace simpleCiphers
{
    public class railFenceCipher : transpositionCipher //, IBruteForce
    {
        // fields
        private int _currentLine { get; set; }
        private int _currentDirection { get; set; }
        private List<StringBuilder> fenceLines = new List<StringBuilder>();


        // getters and setters
        // use default

        // constructors
        public railFenceCipher()
        {
            _currentLine = 0;
            _currentDirection = 1;
        }

        // methods

        // I wrote two encipher functions to demonstrate polymorphism
        // via overloading methods
        public string encipher(string inputText)
        {
            // default railFence size is 2
            return this.encipher(inputText, 2);
        }

        public string encipher(string inputText, int numLines)
        {
            inputText = this.cleanText(inputText);

            for (int i = 0; i < numLines; i++)
                fenceLines.Add(new StringBuilder());

            _currentLine = 0;
            _currentDirection = 1;

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < inputText.Length; i++)
            {
                fenceLines[_currentLine].Append(inputText[i]);

                if (_currentLine == 0)
                    _currentDirection = 1;
                else if (_currentLine == numLines - 1)
                    _currentDirection = -1;

                _currentLine += _currentDirection;
            }


            for (int i = 0; i < numLines; i++)
                output.Append(fenceLines[i].ToString());

            return output.ToString();
        }

        public string decipher(string inputText, int numLines)
        {
            inputText = this.cleanText(inputText);

            for (int i = 0; i < numLines; i++)
                fenceLines.Add(new StringBuilder());

            int[] lineLengths = Enumerable.Repeat(0, numLines).ToArray();

            int currentLine = 0;
            int direction = 1;

            for (int i = 0; i < inputText.Length; i++)
            {
                lineLengths[currentLine]++;

                if (currentLine == 0)
                    direction = 1;
                else if (currentLine == numLines - 1)
                    direction = -1;

                currentLine += direction;
            }

            int currentChar = 0;

            for (int line = 0; line < numLines; line++)
            {
                for (int i = 0; i < lineLengths[line]; i++)
                {
                    fenceLines[line].Append(inputText[currentChar]);
                    currentChar++;
                }
            }

            StringBuilder output = new StringBuilder();

            currentLine = 0;
            direction = 1;

            int[] currentReadLine = Enumerable.Repeat(0, numLines).ToArray();

            for (int i = 0; i < inputText.Length; i++)
            {

                output.Append(fenceLines[currentLine][currentReadLine[currentLine]]);
                currentReadLine[currentLine]++;

                if (currentLine == 0)
                    direction = 1;
                else if (currentLine == numLines - 1)
                    direction = -1;

                currentLine += direction;
            }

            return output.ToString();
        }


        // TODO: This is causing a problem with the decipher function. I'm not
        // sure why. It is throwing an index out of bounds error at line 79.
        // I haven't been able to find the cause and need to investigate further.

        // This function is intended to implement the IBruteForce interface and
        // iterate through several fence sizes to see if an ungarbled message
        // pops out of the results. It would make it easy to break this encryption
        // if I could just figure out that index out of bounds bug.

        //public void bruteForceDecipher(string inputText)
        //{
        //    railFenceCipher unknownKey = new railFenceCipher();

        //    int numLines = inputText.Length / 2;

        //    for (int i = 0; i < numLines; i++)
        //        unknownKey.decipher(inputText, i);
        //}

    }
}