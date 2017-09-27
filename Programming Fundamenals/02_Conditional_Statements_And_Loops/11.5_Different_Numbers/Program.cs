using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int num1 = first; num1 <= second - 4; num1++) 
            {
                for (int num2 = first+1; num2 <= second - 3; num2++) 
                {
                    for (int num3 = first+2; num3 <= second - 2; num3++) 
                    {
                        for (int num4 = first+3; num4 <= second - 1; num4++)  
                        {
                            for (int num5 = first; num5 <= second; num5++) 
                            {
                                counter++;
                                Console.Write($"{num5} ");
                                if (counter >= 5 )
                                    break;
                            }
                            Console.WriteLine();
                            counter = 0;
                        }
                    }
                }
                
            }
        }
    }
}
