using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _01.__Valid_Usernames
{
    class ValidUsernames
    {
        static void Main()
        {
            string[] userNames = Console.ReadLine()
                .Split(", ");

            for (int i = 0; i < userNames.Length; i++)
            {
                string currentUserName = userNames[i];

                bool isLengthValid = true;
                bool isNameValid = true;

                if (currentUserName.Length < 3 || currentUserName.Length > 16)
                {
                    isLengthValid = false;
                }

                for (int j = 0; j < currentUserName.Length; j++)
                {
                    char currentChar = currentUserName[j];

                    if (!char.IsLetterOrDigit(currentChar) && currentChar != '-' && currentChar != '_')
                    {
                        isNameValid = false;
                        break;
                    }
                }

                if (isLengthValid && isNameValid)
                {
                    Console.WriteLine(currentUserName);
                }
            }
        }
    }
}
