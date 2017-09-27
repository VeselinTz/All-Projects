using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nCount = int.Parse(Console.ReadLine());
            double pStudio = 68 * nCount;
            double pDouble = 77 * nCount;
            double pSuite = 89 * nCount;
            switch (month)
            {
                case "May":
                    {
                        pStudio = 50 * nCount;
                        pDouble = 65 * nCount;
                        pSuite = 75 * nCount;
                        if (nCount > 7)
                            pStudio -= (0.05 * 50) * nCount;
                        break;
                    }
                case "October":
                    {
                        pStudio = 50 * nCount;
                        pDouble = 65 * nCount;
                        pSuite = 75 * nCount;
                        if (nCount > 7)
                        {
                            nCount--;
                            pStudio -= (0.05 * 50) * nCount;
                            
                        }
                        break;
                    }
                case "June":
                    {
                        pStudio = 60 * nCount;
                        pDouble = 72 * nCount;
                        pSuite = 82 * nCount;
                        if (nCount > 14)
                            pDouble -= (0.1 * 72) * nCount;
                        break;
                    }
                case "September":
                    {
                        pStudio = 60 * nCount;
                        pDouble = 72 * nCount;
                        pSuite = 82 * nCount;
                        if (nCount > 14)
                            pDouble -= (0.1 * 72) * nCount;
                        
                        if (nCount > 7)
                        { 
                             nCount--;
                             pStudio = 60 * nCount;
                        }
                        break;
                    }
                default:
                    {
                        pStudio = 68 * nCount;
                        pDouble = 77 * nCount;
                        pSuite = 89 * nCount;
                        if (nCount > 14)
                            pSuite -= (0.15 * 89) * nCount;
                        break;
                    }

            }
            Console.WriteLine($"Studio: {string.Format("{0:##.00}", pStudio)} lv.");
            Console.WriteLine($"Double: {string.Format("{0:##.00}", pDouble)} lv.");
            Console.WriteLine($"Suite: {string.Format("{0:##.00}", pSuite)} lv.");

        }
    }
}
