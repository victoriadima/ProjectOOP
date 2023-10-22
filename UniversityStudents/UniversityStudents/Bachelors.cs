using System;


namespace UniversityStudents
{
    public class Bachelors : Student, IGraduate, IScholarship
    {
        public double FinalGrade { get; set; }
        public string GraduatedFrom { get; set; }

        public Bachelors()
        {

        }

        public Bachelors(string name, int admissionYear, int finalGrade, string graduatedFrom) : base(name, admissionYear)
        {
            FinalGrade = finalGrade;
            GraduatedFrom = graduatedFrom;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Final grade: {FinalGrade}");
            Console.WriteLine($"Graduated from: {GraduatedFrom}");
            Console.WriteLine($"Graduates this year: {GraduatesThisYear()}");
            Console.WriteLine($"Student's scholarship: {Scholarship()}");
        }

        public bool GraduatesThisYear()
        {
            if (DateTime.Now.Year - AdmissionYear > 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Scholarship()
        {
            if (FinalGrade >= 8.00 && FinalGrade < 8.5)
            {
                return 725;
            }
            else if (FinalGrade >= 8.5 && FinalGrade < 9)
            {
                return 790;
            }
            else if (FinalGrade >= 9)
            {
                return 925;
            }
            else
            {
                return 0;
            }
        }

    }
}

