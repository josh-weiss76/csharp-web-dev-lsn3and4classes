using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student newStudent = new Student("Josh", 123, 1, 4.0);
            List<Student>currentEnrollment = Course.ClassList();
            Console.WriteLine("There are " + currentEnrollment.Count + "students in the class.");
            
        }
    }
}
