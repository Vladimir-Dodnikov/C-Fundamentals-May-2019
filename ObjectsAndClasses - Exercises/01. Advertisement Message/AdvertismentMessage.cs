using System;

namespace _01._Advertisement_Message
{
    class AdvertismentMessage
    {
        static void Main()
        {
            string[] Phrases =
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] Events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] Authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            string[] Cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            var random = new Random();

            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                var randomIndexPhrases = random.Next(0, Phrases.Length);
                var randomIndexEvents = random.Next(0, Events.Length);
                var randomIndexAuthors = random.Next(0, Authors.Length);
                var randomIndexCities = random.Next(0, Cities.Length);

                var randomPhrase = Phrases[randomIndexPhrases];
                var randomEvents = Events[randomIndexEvents];
                var randomAuthors = Authors[randomIndexAuthors];
                var randomCities = Cities[randomIndexCities];

                Console.WriteLine($"{randomPhrase} {randomEvents} {randomAuthors} - {randomCities}.");
            }
        }
    }
}
