using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] mainData = Console.ReadLine()
              .Split(new char[] { ' ' })
              .ToArray();

            var Dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++) 
            {
                string user = mainData[1];
                string IP = mainData[0];
                int duration = Convert.ToInt32(mainData[2]);

                if (!Dict.ContainsKey(user))
                {
                    Dict.Add(user, new Dictionary<string, int>());
                    Dict[user].Add(IP, duration);
                }
                else
                    if (!Dict[user].ContainsKey(IP))
                    Dict[user].Add(IP, duration);
                else
                    Dict[user]

                mainData = Console.ReadLine()
                .Split(new char[] { '|' })
                .ToArray();
            }
        }
    }
}
