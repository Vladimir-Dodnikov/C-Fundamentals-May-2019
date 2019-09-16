using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class NeitherRealms
    {
        static void Main()
        {
            string healthPattern = @"[^0-9\+\-\*\/.]";
            //string healthPattern = @"[A-Za-z]";           //v Judge dava 30/100
            Regex healthRegex = new Regex(healthPattern);

            string digitPattern = @"-?\d+\.*\d*";     
            //string digitPattern = @"[-+]?\d+([.]\d)?";      // i s tova 30/100
            Regex digitRegex = new Regex(digitPattern);

            string operatorPattern = @"[*\/]";
            //string operatorPattern = @"[*|\/]";           //ako ima | dava 90/100
            Regex operatorRegex = new Regex(operatorPattern);

            string[] names = Regex
                .Split(Console.ReadLine(), @"\s*,\s*")
                .OrderBy(x=>x)
                .ToArray();

            for (int i = 0; i < names.Length; i++)
            {
                string currentDemonName = names[i];

                int currentHealth = 0;

                MatchCollection healthSymbols = healthRegex.Matches(currentDemonName);

                foreach (Match health in healthSymbols)
                {
                    currentHealth += char.Parse(health.Value);
                }

                double baseDamage = 0;

                MatchCollection digitSymbols = digitRegex.Matches(currentDemonName);
                foreach (Match digit in digitSymbols)
                {
                    baseDamage += double.Parse(digit.Value);
                }

                MatchCollection operatorDamage = operatorRegex.Matches(currentDemonName);
                foreach (Match damageSymbol in operatorDamage)
                {
                    string @operator = damageSymbol.Value;
                    if (@operator == "*")
                    {
                        baseDamage *= 2;
                    }
                    else
                    {
                        baseDamage /= 2;
                    }
                }

                Console.WriteLine($"{currentDemonName} - {currentHealth} health, {baseDamage:f2} damage");
            }   
        }
    }
}
