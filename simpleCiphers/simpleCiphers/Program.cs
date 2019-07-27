// I used a few websites to get an idea of different algorithm implementations.
// I didn't use one in particular but I took concepts from a few and wrote my
// code to implement the class. I find that reading others' code teaches me new
// techniques that I would otherwise not be exposed to. For instance,
// I learned about StringBuilder and Enumerable thanks to one I found online.
//
// As a second check of my work, I used another of my favorite
// websites: www.dcode.fr

using System;

namespace simpleCiphers
{
    class Program
    {
        static void Main(string[] args)
        {
            // test railFenceCipher encrypt
            railFenceCipher myTest = new railFenceCipher();
            string inputText = "CSC260 was a really great $%$## class!!!";
            string encipheredTest = myTest.encipher(inputText, 3);
            Console.WriteLine(encipheredTest);
            string decipheredText = myTest.decipher(inputText, 3);
            Console.WriteLine(decipheredText);






            Console.ReadKey();
        }
    }
}
