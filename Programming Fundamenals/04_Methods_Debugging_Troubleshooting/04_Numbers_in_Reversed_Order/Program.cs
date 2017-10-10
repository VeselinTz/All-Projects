using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Numbers_in_Reversed_Order
{
    class Program
    {
        static void Reverse(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Reverse(number);
        }
    }
}
