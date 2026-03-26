using System;
using System.Collections.Generic;
using System.Text;

namespace discon
{
    internal class ReportGenerator
    {
        public void GenerateReport(List<Student> students)
        { 
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Studentid}");
                Console.WriteLine($"Name: {student.Studentname}");
                Console.WriteLine($"Marks: {student.Marks}");
                string grade = GetGrade(student.Marks);
                Console.WriteLine($"Grade: {grade}");
               
            }
        }

        private string GetGrade(int marks)
        {
            if (marks >= 90) return "A";
            else if (marks >= 75) return "B";
            else if (marks >= 50) return "C";
            else return "Fail";
        }
    }
}
