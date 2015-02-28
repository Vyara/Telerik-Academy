//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. 
//When the last key character is reached, the next is the first.


using System;
using System.Text;



class EncodeDecode
{
    static void Main()
    {
        string input;
        string key;
        //asks user for input
        Console.Write("Please enter text: ");
        input = Console.ReadLine();
        Console.WriteLine("--------------------------------------------------");
        Console.Write("Please enter a key: ");
        key = Console.ReadLine();

        //uses EncryptOrDecrypt() and prints the result
        string encryptedText = EncryptOrDecrypt(input, key);
        string decryptedText = EncryptOrDecrypt(encryptedText, key);
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Encrypted: ");
        Console.WriteLine(encryptedText);
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Decrypted: ");
        Console.WriteLine(decryptedText);



    }

    //method for encrypting and decrypting
    static string EncryptOrDecrypt(string text, string key)
    {
        var cipher = new StringBuilder(text.Length);

        for (int i = 0; i < text.Length; i++)
        {
            cipher.Append((char)(text[i] ^ key[i % key.Length]));
        }

        return cipher.ToString();
    }
}

