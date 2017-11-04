using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _04_Students_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string[] INPUT = File.ReadAllLines("input.txt");
            File.Delete("output.txt");
            for (int i = 1; i <= Convert.ToInt32(INPUT[0]); i++)
            {
                Student student = new Student();
                string[] input = INPUT[i].Split();

                student.name = input[0];
                student.grades =
                    input.Skip(1).Select(double.Parse).ToList();
                students.Add(student);
            }
            students
                .Where(s => s.Average >= 5.00)
                .OrderBy(s => s.name)
                .ThenByDescending(s => s.Average)
                .ToList()
                .ForEach(s => File.AppendAllText("output.txt",$"{s.name} -> {s.Average:F2}{Environment.NewLine}") );
        }
    }
    class Student
    {
        public string name { get; set; }

        public List<double> grades { get; set; }

        public double Average => grades.Average();
    }
}
