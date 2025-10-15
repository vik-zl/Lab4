    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    namespace Lab4
    {
        public partial class ChamplainStudent : Person, IGrading
        {

       
            public int StudentID { get; set; }
            public int YearOfRegistration { get; set; }
            public double Zscore { get; set; }


            public List<int> StudentIds { get; set; } = new List<int>();
            public List<string> CourseId { get; set; } = new List<string>();
            public List<string> CourseName { get; set; } = new List<string>();
            public List<double> Score { get; set; } = new List<double>();
            public List<string> GroupId { get; set; } = new List<string>();
            public List<int> IRG { get; set; } = new List<int>();




            public override void DisplayInfo()
            {
                Console.WriteLine($"Student: {name} ({StudentID})");
                Console.WriteLine($"Age: {age}, Gender: {gender}, DOB: {DateofBirth.ToShortDateString()}");
                Console.WriteLine($"Year of Registration: {YearOfRegistration}");


            }
        }
    }





















       