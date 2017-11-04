using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[3] { '0', '1', '2' };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Convert.ToInt32(chars[i]));
            }
        }
    }
}
