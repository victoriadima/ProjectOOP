using System;

namespace UniversityStudents
{
    public class Masters : Student, IGraduate
    {
        public string MastersThesis { get; set; }

        public Masters()
        {
        }

        public Masters(string name, int admissionYear, string mastersThesis) : base(name, admissionYear)
        {
            MastersThesis = mastersThesis;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Thesis Subject: {MastersThesis}");
            Console.WriteLine($"Graduates this year: {GraduatesThisYear()}");
        }

        public bool GraduatesThisYear()
        {
            if (DateTime.Now.Year - AdmissionYear > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

