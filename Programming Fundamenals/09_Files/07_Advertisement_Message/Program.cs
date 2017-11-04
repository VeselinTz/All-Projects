using System;
using System.IO;
namespace _02_Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Phrases = new string[] {
                "Excellent product. ",
                "Such a great product. ",
                "I always use that product. ",
                "Best product of its category. ",
                "Exceptional product. ",
                "I can’t live without this product. "};
            string[] Events = new string[] {
                "Now I feel good.",
                "I have succeeded with this product. ",
                "Makes miracles. I am happy of the results! ",
                "I cannot believe but now I feel awesome. ",
                "Try it yourself, I am very satisfied. ",
                "I feel great! " };
            string[] Autohors = new string[] {
                "Diana ",
                "Petya ",
                "Stella ",
                "Elena ",
                "Katya ",
                "Iva ",
                "Annie ",
                "Eva " };
            string[] Cities = new string[] {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse" };

            
            int n = int.Parse(File.ReadAllText("input.txt"));
            Random random = new Random();
            File.Delete("output.txt");
            for (int i = 0; i < n; i++)
            {
                int randomNumber = random.Next(0, 6);
                File.AppendAllText("otuput.txt",Phrases[randomNumber]);
                randomNumber = random.Next(0, 6);
                File.AppendAllText("otuput.txt", Events[randomNumber]);
                randomNumber = random.Next(0, 8);
                File.AppendAllText("otuput.txt", Autohors[randomNumber]);
                randomNumber = random.Next(0, 5);
                File.AppendAllText("otuput.txt", Cities[randomNumber] + Environment.NewLine);
            }

        }
    }
}
