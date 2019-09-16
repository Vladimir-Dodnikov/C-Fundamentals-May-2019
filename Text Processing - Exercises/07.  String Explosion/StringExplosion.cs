using System;

namespace _07.__String_Explosion
{
    class StringExplosion
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] splitted = input.Split('>');

            string result = splitted[0];

            int remainPower = 0;

            for (int i = 1; i < splitted.Length; i++)
            {
                result += '>';
                string a = splitted[i];
                int length = splitted[i].Length;
                //string currentStr = splitted[i][0].ToString();
                char digitSymbol = splitted[i][0];

                int power = int.Parse(digitSymbol.ToString()) + remainPower;

                if (power > splitted[i].Length)
                {
                    remainPower = power - splitted[i].Length;
                }
                else
                {
                    result += splitted[i].Substring(power);
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
