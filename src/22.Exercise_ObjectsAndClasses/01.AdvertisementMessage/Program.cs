using System;

namespace _01.AdvertisementMessage
{
    public class Items
    {
        public static string[] Phrases { get; set; } = new[]
        {
            "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."
        };

        public static string[] Event { get; set; } = new []
        {
            "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
        };

        public static string[] Authors { get; set; } = new[]
        {
            "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
        };

        public static string[] Cities { get; set; } = new[]
        {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        };
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            var randomPhase = random.Next(Items.Phrases.Length);
            var randomEvent = random.Next(Items.Event.Length);
            var randomAuthor = random.Next(Items.Authors.Length);
            var randomCity = random.Next(Items.Cities.Length);

            Console.WriteLine($"{Items.Phrases[randomPhase]} {Items.Event[randomEvent]} {Items.Authors[randomAuthor]} – {Items.Cities[randomCity]}.");
        }
    }
}