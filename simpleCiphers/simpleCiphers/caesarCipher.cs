// Caesar ciphers are probably the easiest substitution cipher. They simply shift the
// letters by an integer key value. For instance:
//
// Key = 1
// Plain Text: OOP
// Enciphered Text: PPQ
//
// These are really easy to encode, decode, and break. For this reason, they aren't
// in use for anything that requires true security. They are fun to work on however
// and are the building blocks for many other types of substitution ciphers.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace simpleCiphers
{
    public class caesarCipher : substitutionCipher, IBruteForce
    {
        // fields
        // none

        // getters and setters
        // default

        // constructors
        // default

        // methods

        // Caesar ciphers don't handle anything other than numbers very well because the ASCII table
        // doesn't have the numbers next to the alphabet characters. I decided to remove them for
        // this exercise. It simplified my code but also gave me an opportunity to demonsrate some
        // more OOP principles by overriding the cleanText method inherited from the cipher class.
        // Again, this is somewhat contrived, but I believe it is appropriate as a learning experience.
        public override string cleanText(string inputText)
        {
            inputText = inputText.ToUpper();
            inputText = Regex.Replace(inputText, @"[^A-Z]", string.Empty); // removed 0-9 here

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

        // I implemented the IBruteForce interface here. This cycles through
        // the decrypt 26 times, or each possible shift in the alphabet. You
        // have to manually look through the output and decide what is the 
        // intended text but it is pretty obvious and really fast.
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
