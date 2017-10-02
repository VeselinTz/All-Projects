using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Practice_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (byte i = 0; i < 7; i++)
            {
                var num = long.Parse(Console.ReadLine());
                if (num >= -128 && num <= 127)
                {
                    sbyte num2 = (sbyte)num;
                    Console.WriteLine(num2);
                }
                else if (num >= 0 && num <= 255)
                {
                    byte num2 = (byte)num;
                    Console.WriteLine(num2);
                }
                else if (num >= -32768 && num <= 32767)
                {
                    short num2 = (short)num;
                    Console.WriteLine(num2);
                }
                else if (num >= 0 && num <= 65535)
                {
                    ushort num2 = (ushort)num;
                    Console.WriteLine(num2);
                }
                else if (num >= -2147483648 && num <= 2147483647)
                {
                    int num2 = (int)num;
                    Console.WriteLine(num2);
                }
                else if (num >= 0 && num <= 4294967295)
                {
                    uint num2 = (uint)num;
                    Console.WriteLine(num2);
                }
                else
                {
                    long num2 = (long)num;
                    Console.WriteLine(num2);
                }
            }
        }
    }
}
