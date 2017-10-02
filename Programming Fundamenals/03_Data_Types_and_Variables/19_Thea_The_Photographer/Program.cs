using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());
            uint FT = uint.Parse(Console.ReadLine());
            byte FF = byte.Parse(Console.ReadLine());
            uint UT = uint.Parse(Console.ReadLine());

            uint secs = ((N * FF)/100)*UT + N*FT;
            TimeSpan t = TimeSpan.FromSeconds(secs);


            string answer = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                            t.Days,
                            t.Hours,
                            t.Minutes,
                            t.Seconds);
            Console.WriteLine(answer);
        }
    }
}
