using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace simpleCiphers
{
    class caesarCipher : substitutionCipher, IBruteForce
    {
        // fields
        // none

        // getters and setters
        // default

        // constructors
        // default

        // methods
        public override string cleanText(string inputText)
        {
            inputText = inputText.ToUpper();
            inputText = Regex.Replace(inputText, @"[^A-Z]", string.Empty);

            return inputText;
        }

        public string encipher(string inputText, int key)
        {
            string output = string.Empty;

            inputText = this.cleanText(inputText);

            foreach (char ch in inputText)
            {
                output += (char)((((ch + key) - 65) % 26) + 65);
            }

            return output;
        }

        public string decipher(string inputText, int key)
        {
            return encipher(inputText, 26 - key);
        }

        public void bruteForceDecipher(string inputText)
        {
            caesarCipher unknownKey = new caesarCipher();

            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(unknownKey.decipher(inputText, i));
            }
        }
    }
}
