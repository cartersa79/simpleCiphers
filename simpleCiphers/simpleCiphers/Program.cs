using System;

namespace simpleCiphers
{
    class Program
    {
        static void Main(string[] args)
        {
            // test railFenceCipher encipher and decipher
            Console.WriteLine("This is testing the Rail Fence Cipher:");
            railFenceCipher myTest = new railFenceCipher();
            string inputText = "CSC260 was a really great $%$## class!!!";
            string encipheredTest = myTest.encipher(inputText, 3);
            Console.WriteLine(encipheredTest);
            string decipheredTest = myTest.decipher(encipheredTest, 3);
            Console.WriteLine(decipheredTest);
            Console.WriteLine("\n");

            // test Jefferson cipher
            Console.WriteLine("This is testing the Jefferson Wheel Cipher Cipher:");
            jeffersonWheelCipher testTJ = new jeffersonWheelCipher();
            string wheelTestInput = "Hello World!";
            string wheelTestEnciphered = testTJ.encipher(wheelTestInput, 10);
            Console.WriteLine(wheelTestEnciphered);
            string wheelTestDeciphered = testTJ.decipher(wheelTestEnciphered, 10);
            Console.WriteLine(wheelTestDeciphered);
            Console.WriteLine("\n");

            // test Caesar cipher
            Console.WriteLine("This is testing the Caesar Cipher:");
            caesarCipher testCaesar = new caesarCipher();
            string caesarTestInput = "I truly enjoyed the course, Thanks!";
            string caesarEncipheredTest = testCaesar.encipher(caesarTestInput, 1);
            Console.WriteLine(caesarEncipheredTest);
            Console.WriteLine(testCaesar.decipher(caesarEncipheredTest, 1));
            Console.WriteLine("\nThis is the Brute Force Breaking of the Caesar Cipher:");
            testCaesar.bruteForceDecipher(caesarEncipheredTest);

            Console.ReadKey();
        }
    }
}
