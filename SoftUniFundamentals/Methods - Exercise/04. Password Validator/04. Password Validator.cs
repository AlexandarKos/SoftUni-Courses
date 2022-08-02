using System;
using System.Linq;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            isValid(password);
        }

        static void isValid(string password)
        {


            if (IsInRange(password) && HasOnlyLettersOrDigit(password) && HasAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
            if (!IsInRange(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!HasOnlyLettersOrDigit(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!HasAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool HasAtLeastTwoDigits(string password)
        {
            int digitsCount = 0;
            foreach (var character in password)
            {
                if (char.IsDigit(character))
                {
                    digitsCount++;
                }
            }
            if (digitsCount >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool HasOnlyLettersOrDigit(string password)
        {
            if (!password.All(Char.IsLetterOrDigit))
            {
                return false;
            }
            return true;
        }

        static bool IsInRange(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {                
                return false;
            }
            return true;
        }
    }
}
