using System;
using System.Linq;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputMessage = Console.ReadLine();

            StringBuilder encryptedMessage = new StringBuilder();

            for (int i = 0; i < inputMessage.Length; i++)
            {
                char encryptedChar = (char)(inputMessage[i] + 3);
                encryptedMessage.Append(encryptedChar);
            }

            Console.WriteLine(encryptedMessage);
        }
    }
}
