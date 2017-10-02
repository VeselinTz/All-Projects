using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            uint distance = uint.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            float time_s = minutes*60 + hours * 3600 + seconds;

            Console.WriteLine((float)(distance / time_s));
            Console.WriteLine((float)(distance / time_s * 3.6));
            Console.WriteLine((float)(distance / 1609.0)/( time_s/3600));

        }
    }
}
