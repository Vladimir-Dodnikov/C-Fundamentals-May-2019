﻿using System;

namespace _5._Messages
{
    class Messages
    {
        static void Main(string[] args)
        {
            int tapTimes = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 0; i < tapTimes; i++)
            {
                string input = Console.ReadLine();
                int numberOfDigits = input.Length;
                char buttonNumber = input[0];

                if (buttonNumber == '2')
                {
                    if (numberOfDigits == 1)
                    {
                        message += "a";
                    }
                    else if (numberOfDigits == 2)
                    {
                        message += "b";
                    }
                    else if (numberOfDigits == 3)
                    {
                        message += "c";
                    }
                }
                else if (buttonNumber == '3')
                {
                    if (numberOfDigits == 1)
                    {
                        message += "d";
                    }
                    else if (numberOfDigits == 2)
                    {
                        message += "e";
                    }
                    else if (numberOfDigits == 3)
                    {
                        message += "f";
                    }
                }
                else if (buttonNumber == '4')
                {
                    if (numberOfDigits == 1)
                    {
                        message += "g";
                    }
                    else if (numberOfDigits == 2)
                    {
                        message += "h"; ;
                    }
                    else if (numberOfDigits == 3)
                    {
                        message += "i";
                    }
                }
                else if (buttonNumber == '5')
                {
                    if (numberOfDigits == 1)
                    {
                        message += "j";
                    }
                    else if (numberOfDigits == 2)
                    {
                        message += "k";
                    }
                    else if (numberOfDigits == 3)
                    {
                        message += "l";
                    }
                }
                else if (buttonNumber == '6')
                {
                    if (numberOfDigits == 1)
                    {
                        message += "m";
                    }
                    else if (numberOfDigits == 2)
                    {
                        message += "n";
                    }
                    else if (numberOfDigits == 3)
                    {
                        message += "o";
                    }
                }
                else if (buttonNumber == '7')
                {
                    if (numberOfDigits == 1)
                    {
                        message += "p";
                    }
                    else if (numberOfDigits == 2)
                    {
                        message += "q";
                    }
                    else if (numberOfDigits == 3)
                    {
                        message += "r";
                    }
                    else if (numberOfDigits == 4)
                    {
                        message += "s";
                    }
                }
                else if (buttonNumber == '8')
                {
                    if (numberOfDigits == 1)
                    {
                        message += "t";
                    }
                    else if (numberOfDigits == 2)
                    {
                        message += "u";
                    }
                    else if (numberOfDigits == 3)
                    {
                        message += "v";
                    }
                }
                else if (buttonNumber == '9')
                {
                    if (numberOfDigits == 1)
                    {
                        message += "w";
                    }
                    else if (numberOfDigits == 2)
                    {
                        message += "x";
                    }
                    else if (numberOfDigits == 3)
                    {
                        message += "y";
                    }
                    else if (numberOfDigits == 4)
                    {
                        message += "z";
                    }
                }
                else if (buttonNumber == '0')
                {
                    message += " ";
                }
            }
            Console.WriteLine(message);
        }
    }
}
