namespace _04._Password_Validator
{
    using System;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValidLength = CheckTheLengthOfPassword(password);
            bool isNumericAlpha = CheckPassForLettersAndDigits(password);
            bool isValidCountOfDigits = CheckPassForCountOfDigits(password);

            if (!isValidLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isNumericAlpha)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isValidCountOfDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValidCountOfDigits && isNumericAlpha && isValidLength)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckTheLengthOfPassword(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }

        static bool CheckPassForLettersAndDigits(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckPassForCountOfDigits(string password)
        {
            int digitCounter = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitCounter++;
                }
            }
            return digitCounter >= 2;
        }
    }
}