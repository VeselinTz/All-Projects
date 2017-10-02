using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = Console.ReadLine();
            string world = Console.ReadLine();

            string helloWorld = (string)(hello + " " + world);

            Console.WriteLine(helloWorld);
        }
    }
}
