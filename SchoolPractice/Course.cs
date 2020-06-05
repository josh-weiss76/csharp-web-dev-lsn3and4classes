using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public static List<Student> ClassList ()
        {
            var studentList = new List<Student>();
            var adding = true;

            while (adding)
            {
                Student newStudent = new Student();

                Console.Write("Student Name: ");
                newStudent.Name = Console.ReadLine();

                Console.Write("Student ID number: ");
                newStudent.StudentId = int.Parse(Console.ReadLine());

                Console.Write("Number of credits: ");
                newStudent.NumberOfCredits = int.Parse(Console.ReadLine());

                Console.Write("Student GPA: ");
                newStudent.Gpa = double.Parse(Console.ReadLine());

                studentList.Add(newStudent);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }
            return studentList;
        }
    }
}
