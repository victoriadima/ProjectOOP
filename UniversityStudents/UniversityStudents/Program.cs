using System;
using System.Collections.Generic;

namespace UniversityStudents
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Bachelors> bachelors = new List<Bachelors>();
            List<Masters> masters = new List<Masters>();

            while (true)
            {
                Console.WriteLine("\nStudent Management System Menu:");
                Console.WriteLine("1. Add Bachelor's Student");
                Console.WriteLine("2. Add Master's Student");
                Console.WriteLine("3. Remove Bachelor's Student");
                Console.WriteLine("4. Remove Master's Student");
                Console.WriteLine("5. Display All Bachelor's Students");
                Console.WriteLine("6. Display All Master's Students");
                Console.WriteLine("7. Display Bachelor's Students' Graduation Statistics: ");
                Console.WriteLine("8. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBachelors(bachelors);
                        break;
                    case 2:
                        AddMasters(masters);
                        break;
                    case 3:
                        RemoveBachelors(bachelors);
                        break;
                    case 4:
                        RemoveMasters(masters);
                        break;
                    case 5:
                        Console.WriteLine("\nAll Bachelor's Students:");
                        foreach (var bachelorsStudent in bachelors)
                        {
                            bachelorsStudent.DisplayDetails();
                        }
                        break;
                    case 6:
                        Console.WriteLine("\nAll Master's Students:");
                        foreach (var mastersStudent in masters)
                        {
                            mastersStudent.DisplayDetails();
                        }
                        break;
                    case 7:
                        Console.WriteLine("Graduation Statistics of Bachelor Students: ");
                        GraduationStatistics(bachelors);
                        break;
                    case 8:
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choide! Please try again.");
                        break;
                }
            }
        }


        private static void AddBachelors(List<Bachelors> bachelors)
        {
            Console.WriteLine("\nEnter student's details: ");
            Bachelors bachelorsStudent = new Bachelors();
            Console.WriteLine("Name:");
            bachelorsStudent.Name = Console.ReadLine();
            Console.WriteLine("Admission Year:");
            bachelorsStudent.AdmissionYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Last month's final grade:");
            bachelorsStudent.FinalGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("Graduated from (High School / College):");
            bachelorsStudent.GraduatedFrom = Console.ReadLine();

            bachelors.Add(bachelorsStudent);
            Console.WriteLine("Student added successfully!");
        }

        private static void AddMasters(List<Masters> masters)
        {
            Console.WriteLine("\nEnter student's details: ");
            Masters mastersStudent = new Masters();
            Console.WriteLine("Name:");
            mastersStudent.Name = Console.ReadLine();
            Console.WriteLine("Admission Year:");
            mastersStudent.AdmissionYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Master's Thesis:");
            mastersStudent.MastersThesis = Console.ReadLine();

            masters.Add(mastersStudent);
            Console.WriteLine("Student added successfully");
        }

        private static void RemoveBachelors(List<Bachelors> bachelors)
        {
            Console.WriteLine("\nEnter the name of the Bachelor's student you want to remove:");
            string bachelorsNameToRemove = Console.ReadLine();

            Bachelors bachelorsToRemove = null;
            foreach (Bachelors bachelorsStudent in bachelors)
            {
                if (bachelorsStudent.Name == bachelorsNameToRemove)
                {
                    bachelorsToRemove = bachelorsStudent;
                    break;
                }
            }
            if (bachelorsToRemove != null)
            {
                bachelors.Remove(bachelorsToRemove);
                Console.WriteLine($"Bachelor's Student {bachelorsNameToRemove} has been removed!");
            }
            else
            {
                Console.WriteLine($"Bachelor's Student {bachelorsNameToRemove} not found!");
            }
        }

        private static void RemoveMasters(List<Masters> masters)
        {
            Console.WriteLine("\nEnter the name of the Master's student you want to remove:");
            string mastersNameToRemove = Console.ReadLine();

            Masters mastersToRemove = null;
            foreach (Masters mastersStudent in masters)
            {
                if (mastersStudent.Name == mastersNameToRemove)
                {
                    mastersToRemove = mastersStudent;
                    break;
                }
            }
            if (mastersToRemove != null)
            {
                masters.Remove(mastersToRemove);
                Console.WriteLine($"Master's Student {mastersNameToRemove} has been removed!");
            }
            else
            {
                Console.WriteLine($"Master's Student {mastersNameToRemove} not found!");
            }
        }

        private static void GraduationStatistics(List<Bachelors> bachelors)
        {
            int graduatedFromCollege = 0;
            int graduatedFromHS;
            foreach (Bachelors bachelorsStudent in bachelors)
            {
                if (bachelorsStudent.GraduatedFrom == "College" || bachelorsStudent.GraduatedFrom == "college")
                {
                    graduatedFromCollege++;
                }
            }
            graduatedFromHS = bachelors.Count - graduatedFromCollege;
            Console.WriteLine($"Bachelor's Students who graduated from High School: {graduatedFromHS}");
            Console.WriteLine($"Bachelor's Students who graduated from College: {graduatedFromCollege}");
        }
    }
}

