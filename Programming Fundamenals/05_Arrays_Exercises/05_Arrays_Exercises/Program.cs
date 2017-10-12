using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int counter2 = 0;
            int counter1 = 0;
            counter1 = Counter(firstArr, secondArr);
            Array.Reverse(firstArr);
            Array.Reverse(secondArr);
            counter2 = Counter(firstArr, secondArr);
            if(counter1>counter2)
            Console.WriteLine(counter1);
            else
            Console.WriteLine(counter2);
        }

        private static int Counter(string[] firstArr, string[] secondArr)
        {
            int counter = 0;
            int lenghtMin = Math.Min(firstArr.Length, secondArr.Length);
            for (int i = 0; i < lenghtMin; i++)
            {
                if (firstArr[i] == secondArr[i])
                    counter++;
                else
                    break;
            }

            return counter;
        }
    }
}
