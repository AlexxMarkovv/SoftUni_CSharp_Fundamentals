using System;

namespace _16._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            string decryptedMessage = "";

            for (int i = 0; i < num; i++)
            {
                char character = char.Parse(Console.ReadLine()) ;
                int charNum = character;
                charNum += key;
                decryptedMessage += (char)charNum;
            }
            Console.WriteLine(decryptedMessage);
        }
    }
}