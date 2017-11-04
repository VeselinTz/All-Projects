using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {

            var player = new Dictionary<string, int>();
            int sum = 0;
            List<string> playerData = Console.ReadLine()
                .Split(new char[] { ' ' })
                .ToList();

            while (playerData[0] != "JOKER")
            {
                if (!player.ContainsKey(playerData[0]))
                    player.Add(playerData[0], 0);

                for (int i = 1; i < playerData.Count; i++)
                    {
                    List<char> card = playerData[i]
                        .ToCharArray()
                        .ToList();
                    if (card[0] == '1' && card[1] == '0')
                    {
                        sum += 10;
                        card.Remove(',');
                    }
                    else
                    if (card[0] >= '0' && card[0] <= ('9'))
                    {
                        sum += Convert.ToInt32(card[0]) - 48;
                    }
                    else
                        switch (card[0])
                        {
                            case 'J':
                                { sum += 11; break; }
                            case 'Q':
                                { sum += 12; break; }
                            case 'K':
                                { sum += 13; break; }
                            case 'A':
                                { sum += 14; break; }
                        }
                    switch (card[1])
                    {
                        case 'S':
                            { sum = sum * 4; break; }
                        case 'H':
                            { sum = sum * 3; break; }
                        case 'D':
                            { sum = sum * 2; break; }
                        case 'C':
                            { sum = sum * 1; break; }
                    }
                    player[playerData[0]] += sum;
                    sum = 0;
                }
                sum = 0;
                playerData.Clear();
                playerData = Console.ReadLine()
                .Split(new char[] { ' ' })
                .ToList();
            }
            foreach (var index in player)
                Console.WriteLine($"{index.Key} {index.Value}");
        }
    }
}
