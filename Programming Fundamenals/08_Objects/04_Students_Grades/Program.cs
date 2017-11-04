﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Students_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List < Student > students = new List<Student>();
            for (int i = 0; i < n; i++) 
            {
                Student student = new Student();
                string[] input = Console.ReadLine().Split();

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
                .ForEach(s => Console.WriteLine($"{s.name} -> {s.Average:F2}"));
        }
    }
    class Student
    {
        public string name { get; set; }

        public List<double> grades { get; set; }

        public double Average => grades.Average();
    }
}
