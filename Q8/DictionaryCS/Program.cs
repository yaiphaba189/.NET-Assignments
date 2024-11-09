using System;
using System.Collections.Generic;

namespace DictionaryExampleCS
{
    class DictionaryProgram
    {
        Dictionary<string, string> StudentNames = new Dictionary<string, string>();
        Dictionary<string, double> StudentGrades = new Dictionary<string, double>();

        public void AddStudentInfo()
        {
            StudentNames.Add("Sakina", "A");
            StudentNames.Add("John", "B");
            StudentNames.Add("Emma", "A+");
            StudentNames.Add("Alex", "B-");
        }

        public void AddGrades()
        {
            StudentGrades.Add("Sakina", 90.5);
            StudentGrades.Add("John", 80.3);
            StudentGrades.Add("Emma", 95.0);
            StudentGrades.Add("Alex", 75.8);
        }

        public static void Main()
        {
            DictionaryProgram program = new DictionaryProgram();
            program.AddStudentInfo();
            program.AddGrades();

            Console.WriteLine("Student Names and their Grades:");
            foreach (var student in program.StudentNames)
            {
                Console.WriteLine($"Student: {student.Key}, Grade: {student.Value}");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Student Names and their Scores:");
            foreach (KeyValuePair<string, double> grade in program.StudentGrades)
            {
                Console.WriteLine($"Student: {grade.Key}, Score: {grade.Value}");
            }

            Console.ReadKey();
        }
    }
}
