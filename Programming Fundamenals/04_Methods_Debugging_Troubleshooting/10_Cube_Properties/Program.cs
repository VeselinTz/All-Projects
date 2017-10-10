using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cube_Properties
{
    class Program
    {
        static double lenghtSPACEdiagonalsOfCube(double sideOfCube)
        {
            return Math.Sqrt(3 * Math.Pow(sideOfCube,2));
        }
        static double lenghtFACEdiagonalsOfCube(double sideOfCube)
        {
            return Math.Sqrt(2 * Math.Pow(sideOfCube, 2));
        }
        static double VolumeOfCube(double sideOfCube)
        {
            return Math.Pow(sideOfCube, 3);
        }
        static double SurfaceAreaOfCube(double sideOfCube)
        {
            return 6 * Math.Pow(sideOfCube, 2);
        }

        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            switch(command)
            {
                case "face":
                    Console.WriteLine(Math.Round(lenghtFACEdiagonalsOfCube(side),2));
                    break;
                case "space":
                    Console.WriteLine(Math.Round(lenghtSPACEdiagonalsOfCube(side),2));
                    break;
                case "volume":
                    Console.WriteLine(Math.Round(VolumeOfCube(side),2));
                    break;
                case "area":
                    Console.WriteLine(Math.Round(SurfaceAreaOfCube(side),2));
                    break;
                default:
                    break;
            }
        }
    }
}
