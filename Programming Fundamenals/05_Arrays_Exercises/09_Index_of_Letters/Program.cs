using System;

namespace _09_Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] letters = word.ToCharArray();

            for (int i = 0; i < letters.Length; i++)
                Console.WriteLine($"{letters[i]} -> {letters[i] - 97}");
                
        }
    }
}
