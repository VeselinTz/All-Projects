using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            var Center1 = new Centre();
            var Center2 = new Centre();

            int[] Circle1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] Circle2 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int r1 = Circle1[2];
            int r2 = Circle2[2];

            Center1.X = Circle1[0];
            Center1.Y = Circle1[1];
            Center2.X = Circle2[0];
            Center2.Y = Circle2[1];
            if (Circle.Colision(Center1, Center2, r1, r2))
                Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
    public class Circle
    {
        public int radius { get; set; }
        public Centre centre { get; set; }

        public static bool Colision(Centre centre1, Centre centre2, int radius1, int radius2)
        {
            double distanceBetweenCentres =
                Math.Sqrt(Math.Pow(centre1.X, 2) + Math.Pow(centre1.Y, 2)) +
                Math.Sqrt(Math.Pow(centre2.X, 2) + Math.Pow(centre2.Y, 2));

            if (distanceBetweenCentres > radius1 + radius2)
                return false;
            else
            return true;
        }
    }
    public class Centre
    {
        public int Y { get; set; }
        public int X { get; set; }
    }
}
