// This is the base class from which the various cipher schemes inherit. It is common
// in the world of ciphers to eliminate characters such as spaces, punctuation, etc.
// from the plain text message. Keeping these in can make it much easier to break
// the cipher. For instance, if you know that every sentence ends in a punctuation mark
// followed by a space, you've given yourself a big head start on cracking the code.
//
// One of the resources that I used quite a bit was https://www.dcode.fr/en. It has a lot
// of good information on these simple ciphers as well as some of the more modern. I've
// even used the site to help implement an RSA encryption program in a discrete math class.
//
// I used a few other websites to get an idea of different algorithm implementations. I
// didn't use one in particular but I took concepts from a few and wrote my own code to
// implement the classes. I find that reading others' code teaches me new techniques
// that I would otherwise not be exposed to. For instance, I learned about StringBuilder
// and Enumerable thanks to one website I found online. I liken learning a new computer
// language to learning a new spoken language. You first have to learn the basic syntax,
// grammar, and other rules but then you get to go out and really expand your vocabulary
// by talking with others and reading in that language. In a sense, that's what we do when
// we read another's code. You pick up on new vocabulary to make you a better developer.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace simpleCiphers
{
    public abstract class cipher
    {
        // fields
        // none

        // getters and setters
        // none        
        
        // constructors
        // not applicable to abstract class

        // methods
        public virtual string cleanText(string inputText)
        {
            inputText = inputText.ToUpper();
            inputText = Regex.Replace(inputText, @"[^A-Z0-9]", string.Empty);

            return inputText;
        }

    }
}
