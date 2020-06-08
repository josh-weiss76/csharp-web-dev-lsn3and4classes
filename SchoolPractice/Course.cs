using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }

        public static List<Student> ClassList()
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
        public Course(Teacher instructor)
        {
            Instructor = instructor;
            enrolledStudents = ClassList();
        }


        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   Topic == course.Topic &&
                   EqualityComparer<Teacher>.Default.Equals(Instructor, course.Instructor) &&
                   EqualityComparer<List<Student>>.Default.Equals(enrolledStudents, course.enrolledStudents);
        }

        public override string ToString()
        {
            return Topic + " is taught by " + Instructor.FirstName + " " + Instructor.LastName + " and has " + enrolledStudents.Count + " students in the course.";
        }



        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.


        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.
    }
}
