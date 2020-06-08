using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student newStudent = new Student("Josh", 123, 60, 4.0);
            //List<Student> currentEnrollment = Course.ClassList();
            //Console.WriteLine("There are " + currentEnrollment.Count + "students in the class.");
            Console.WriteLine(newStudent.GetGradeLevel(newStudent.NumberOfCredits));
            newStudent.AddGrade(15, 3.5);
            //Console.WriteLine(newStudent.Name + " completed " + newStudent.NumberOfCredits + " credits with a GPA of " + newStudent.Gpa);
            Console.WriteLine(newStudent.ToString());
        }
    }
}
