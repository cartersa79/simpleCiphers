using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace simpleCiphers
{
    class railFenceCipher : transpositionCipher //, IBruteForce
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
        // I need to investigate further.

        //public void bruteForceDecipher(string inputText)
        //{
        //    railFenceCipher unknownKey = new railFenceCipher();

        //    int numLines = inputText.Length / 2;

        //    for (int i = 0; i < numLines; i++)
        //        unknownKey.decipher(inputText, i);
        //}

    }
}