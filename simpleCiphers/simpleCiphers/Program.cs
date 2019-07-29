using System;

namespace simpleCiphers
{
    class Program
    {
        static void Main(string[] args)
        {
            // test railFenceCipher encipher and decipher
            railFenceCipher myTest = new railFenceCipher();
            string inputText = "CSC260 was a really great $%$## class!!!";
            string encipheredTest = myTest.encipher(inputText, 3);
            Console.WriteLine(encipheredTest);
            string decipheredText = myTest.decipher(inputText, 3);
            Console.WriteLine(decipheredText);
            Console.WriteLine("\n");

            // test Caesar cipher
            caesarCipher testCaesar = new caesarCipher();
            string caesarTestInput = "I truly enjoyed the course, Thanks!";
            string caesarEncipheredTest = testCaesar.encipher(caesarTestInput, 1);
            Console.WriteLine(caesarEncipheredTest);
            Console.WriteLine(testCaesar.decipher(caesarEncipheredTest, 1));
            Console.WriteLine("\n");
            testCaesar.bruteForceDecipher(caesarEncipheredTest);






            Console.ReadKey();
        }
    }
}
