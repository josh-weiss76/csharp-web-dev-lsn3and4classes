using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student()
        {
        }

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            int newNumberOfCredits = courseCredits + NumberOfCredits;
            double currentPoints = this.NumberOfCredits * this.Gpa;
            double totalPoints = currentPoints + (courseCredits * grade);
            double newGpa = totalPoints / newNumberOfCredits;
            this.Gpa = newGpa;
            this.NumberOfCredits = newNumberOfCredits;
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            if (credits >= 90)
            {
                return "Senior";
            }
            else if (credits >= 60)
            {
                return "Junior";
            }
            else if (credits >= 30)
            {
                return "Sophomore";
            }
            else
            return "Freshman";
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId;
        }
        public override string ToString()
        {
            return Name + " completed " + NumberOfCredits + " credits with a GPA of " + Gpa;
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

    }
}
