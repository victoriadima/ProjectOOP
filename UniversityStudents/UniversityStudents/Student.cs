using System;

namespace UniversityStudents
{
    public abstract class Student
    {
        public string Name { get; set; }
        public int AdmissionYear { get; set; }

        public Student()
        {
        }

        public Student(string name, int admissionYear)
        {
            Name = name;
            AdmissionYear = admissionYear;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Admission Year: {AdmissionYear}");
        }
    }
}


