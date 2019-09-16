using System;

namespace _5._Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string passWord = "";

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                passWord += userName[i];
            }
            for (int i = 0; i < 3; i++)
            {
                string inputPassword = Console.ReadLine();
                if (passWord == inputPassword)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            string lastTryPassword = Console.ReadLine();
            if (passWord == lastTryPassword)
            {
                Console.WriteLine($"User {userName} logged in.");
                return;
            }
            else
            {
                Console.WriteLine($"User {userName} blocked!");
            }
        }
    }
}
