using System;
using System.Linq;

namespace _04._Password_Validator
{
    class PasswordValidator
    {
        static void Main()
        {
            string inputPassword = Console.ReadLine();

            bool isValidChars = CheckCharacters(inputPassword);
            bool isValidConsist = CheckConsistDigitAndLetters(inputPassword);
            bool isValidDigitCount = CheckDigitsCount(inputPassword);

            PrintResult(isValidChars, isValidConsist, isValidDigitCount);
        }

        private static void PrintResult(bool isValidChars, bool isValidConsist, bool isValidDigitCount)
        {
            if (!isValidChars)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isValidConsist)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isValidDigitCount)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValidChars && isValidConsist && isValidDigitCount)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckDigitsCount(string inputPassword)
        {
            string digits = "0123456789";
            int countDigits = 0;

            for (int i = 0; i < inputPassword.Length; i++)
            {
                if (digits.Contains(inputPassword[i]))
                {
                    countDigits++;

                    if (countDigits == 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static bool CheckConsistDigitAndLetters(string inputPassword)
        {
            //string symbols = "$%&'()*+,-./:;<=>?@";

            for (int i = 0; i < inputPassword.Length; i++)
            {
                if (!char.IsLetterOrDigit(inputPassword[i]))
                {
                    return false;
                }
            }
            return true;
        }
        private static bool CheckCharacters(string inputPassword)
        {
            if (inputPassword.Length >= 6 && inputPassword.Length <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
