using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Geometry_Calculator
{
    class Program
    {
        static void triangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("{0:.00}",side * height/2));
        }
        static void squareleArea()
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("{0:.00}", Math.Pow(side,2)));
        }
        static void rectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("{0:.00}", width * height));
        }
        static void circleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("{0:.00}", Math.Pow(radius,2)*Math.PI));
        }
        static void Main(string[] args)
        {
            string typeOfShape = Console.ReadLine().ToLower();
            switch(typeOfShape)
            {
                case "triangle":
                    triangleArea();
                    break;
                case "square":
                    squareleArea();
                    break;
                case "rectangle":
                    rectangleArea();
                    break;
                case "circle":
                    circleArea();
                    break;
            }
        }
    }
}
