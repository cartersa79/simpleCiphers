using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace simpleCiphers
{
    public abstract class cipher
    {
        // fields
        private string _plainText;
        private string _cipherText;


        // getters and setters
        public string PlainText
        {
            get
            {
                return this._plainText;
            }
            set
            {
                // convert user input to all uppercase and use regular expressions to
                // keep only uppercase letters and numbers from 0-9. These will cause
                // challenges in enciphering and deciphering text

                _plainText = _plainText.ToUpper();
                _plainText = Regex.Replace(_plainText, @"[^A-Z0-9]", string.Empty);
            }
        }

        public string CipherText
        {
            get
            {
                return this._cipherText;
            }
            set
            {
                // convert user input to all uppercase and use regular expressions to
                // keep only uppercase letters and numbers from 0-9. These will cause
                // challenges in enciphering and deciphering text

                _cipherText = _cipherText.ToUpper();
                _cipherText = Regex.Replace(_cipherText, @"[^A-Z0-9]", string.Empty);
            }
        }


        // constructors
        // not applicable to abstract class


        // methods


    }
}
