using System;
using System.Collections.Generic;
using System.Text;

namespace discon
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            StudentRepository repo = new StudentRepository();

            repo.AddStudent(new Student { Studentid = 1, Studentname = "Arun", Marks = 85 });
            repo.AddStudent(new Student { Studentid = 2, Studentname = "Priya", Marks = 92 });
 
            ReportGenerator report = new ReportGenerator();
            report.GenerateReport(repo.GetAllStudents());

            Console.ReadLine();
        }
    }
}
