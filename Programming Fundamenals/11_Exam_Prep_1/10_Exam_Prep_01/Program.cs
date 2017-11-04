using System;
using System.Globalization;

namespace _10_Exam_Prep_01
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss",
                CultureInfo.InvariantCulture);

            uint steps = uint.Parse(Console.ReadLine());
            uint timeForStep = uint.Parse(Console.ReadLine());

            time = time.AddSeconds(steps * timeForStep);
            Console.WriteLine($"Time Arrival: {time.Hour:D2}:{time.Minute:D2}:{time.Second:D2}");
        }
    }
}
