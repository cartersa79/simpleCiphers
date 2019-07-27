using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace simpleCiphers
{
    class railFenceCipher : transpositionCipher
    {
        // fields
        private int _currentLine { get; set; }
        private int _currentDirection { get; set; }
        private List<StringBuilder> fenceLines = new List<StringBuilder>();
        private StringBuilder output = new StringBuilder();


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

            _currentLine = 0;
            _currentDirection = 1;

            for (int i = 0; i < inputText.Length; i++)
            {
                lineLengths[_currentLine]++;

                if (_currentLine == 0)
                    _currentDirection = 1;
                else if (_currentLine == numLines - 1)
                    _currentDirection = -1;

                _currentLine += _currentDirection;
            }

            int currentChar = 0;

            for (int lineCounter = 0; lineCounter < numLines; lineCounter++)
            {
                for (int i = 0; i < lineLengths[_currentLine]; i++)
                {
                    fenceLines[_currentLine].Append(inputText[currentChar]);
                    currentChar++;
                }
            }

            _currentLine = 0;
            _currentDirection = 1;

            int[] currentReadLine = Enumerable.Repeat(0, numLines).ToArray();

            for (int i = 0; i < inputText.Length; i++)
            {

                output.Append(fenceLines[_currentLine][currentReadLine[_currentLine]]);
                currentReadLine[_currentLine]++;

                if (_currentLine == 0)
                    _currentDirection = 1;
                else if (_currentLine == numLines - 1)
                    _currentDirection = -1;

                _currentLine += _currentDirection;
            }

            return output.ToString();
        }
    }
}

    
