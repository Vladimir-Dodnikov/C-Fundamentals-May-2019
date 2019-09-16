﻿using System;
using System.Text;

namespace _02._Song_Encryption
{
    class SongEncryption
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string artist = input.Substring(0, input.IndexOf(":"));
                string song = input.Substring(input.IndexOf(":") + 1);

                if (ValidArtist(artist) && ValidSong(song))
                {
                    int length = artist.Length;

                    StringBuilder name = new StringBuilder(); 

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == ':')
                        {
                            name.Append('@');
                        }
                        else if (input[i] == ' ' || input[i] == '\'')
                        {
                            name.Append(input[i]);
                        }
                        else
                        {
                            char symbol = (char)(input[i] + length);

                            if (char.IsUpper(input[i]) && symbol > 'Z')
                            {
                                symbol = (char)(symbol -26);
                            }
                            else if (char.IsLower(input[i]) && symbol > 'z')
                            {
                                symbol = (char)(symbol - 26);
                            }
                            name.Append(symbol);
                        }
                    }
                    Console.WriteLine($"Successful encryption: {name.ToString()}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }

            
        }

        public static bool ValidSong(string song)
        {
            bool isValid = true;

            for (int i = 0; i < song.Length; i++)
            {
                if (!char.IsUpper(song[i]) && song[i] != ' ')
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        public static bool ValidArtist(string artist)
        {
            bool isValid = true;

            if (!char.IsUpper(artist[0]))
            {
                isValid = false;
            }

            for (int i = 1; i < artist.Length; i++)
            {
                if (!char.IsLower(artist[i]) && artist[i] != '\'' && artist[i] != ' ')
                {
                    isValid = false;
                    break;
                }

            }

            return isValid;
        }
    }
}
