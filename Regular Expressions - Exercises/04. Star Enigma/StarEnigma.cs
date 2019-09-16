using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04._Star_Enigma
{
    class StarEnigma
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string firstPatern = @"[STARstar]";

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string encryptCode = Console.ReadLine();

                MatchCollection message = Regex.Matches(encryptCode, firstPatern);

                int countOfLetters = message.Count;

                string decryptedMessage = string.Empty;

                foreach (var letter in encryptCode)
                {
                    decryptedMessage += (char)(letter - countOfLetters);
                }

                string planetPattern = @"[^\@\-!:>]*@(?<name>[\w]+)[^\@\-!:>]*:(?<population>\d+)[^\@\-!:>]*!(?<type>A|D)![^\@\-!:>]*->(?<soldier>[0-9]+)[^\@\-!:>]*";

                Match planetArgs = Regex.Match(decryptedMessage, planetPattern);

                if (planetArgs.Success)
                {
                    string planetName = planetArgs.Groups["name"].Value;
                    string population = planetArgs.Groups["population"].Value;
                    string attackType = planetArgs.Groups["type"].Value;
                    int soldiers = int.Parse(planetArgs.Groups["soldier"].Value);

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet.ToString()}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet.ToString()}");
            }
        }
    }
}
