using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student newStudent = new Student("Josh", 123, 61, 4.0);
            //List<Student> currentEnrollment = Course.ClassList();
            //Console.WriteLine("There are " + currentEnrollment.Count + "students in the class.");
            Console.WriteLine(newStudent.GetGradeLevel(newStudent.NumberOfCredits));

        }
    }
}
