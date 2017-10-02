using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10_Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(100 * centuries);
            uint days = (uint)(365.2422 * years);
            uint hours = 24 * days;
            ulong minutes = 60 * hours;
            ulong seconds = 60 * minutes;
            ulong miliseconds = 1000 * seconds;
            ulong microsecond = 1000 * miliseconds;
            BigInteger nanosecond = 1000 * microsecond;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microsecond} microseconds = {nanosecond} nanoseconds ");
        }
    }
}
