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
        public double Rscore { get; set; }


        public int studentID { get; set; }
        public int yearOfRegistration { get; set; }
        public double zScore { get; set; }

        public string courseID { get; set; }
        public string courseName { get; set; }
        public double score { get; set; }
        public string groupID { get; set; }
        public double irg { get; set; }



        public List<int> StudentIds { get; set; } = new List<int>();
        public List<string> CourseId { get; set; } = new List<string>();
        public List<string> CourseName { get; set; } = new List<string>();
        public List<double> Score { get; set; } = new List<double>();
        public List<string> GroupId { get; set; } = new List<string>();
        public List<int> IRG { get; set; } = new List<int>();




        public double CalculateRScore(double Zscore, double IRG)
        {

            double part1 = Zscore * 5;
            double part2 = part1 + IRG + 35;
            double part3 = part2 / 60;
            double Rscore = part3 * 20;

            return Rscore;
        }

        public double CalculateGPA()
        {
            double average = CalculateGPA();
            if (average >= 90) return 4.0;
            else if (average >= 80) return 3.0;
            else if (average >= 70) return 2.0;
            else if (average >= 60) return 1.0;
            else return 0.0;
        }

        public double CalculateAverage()
        {
            if (Score.Count == 0) return 0;
            return Score.Average();

        }


        public override void DisplayInfo()
        {
            double avgIRG = IRG.Count > 0 ? IRG.Average() : 0; // use average IRG if multiple courses
            double rScore = CalculateRScore(zScore, avgIRG);   // use real calculation

            Console.WriteLine($"Student: {name} ({StudentID})");
            Console.WriteLine($"Age: {age}, Gender: {gender}, DOB: {DateofBirth.ToShortDateString()}");
            Console.WriteLine($"Year of Registration: {YearOfRegistration}");
            Console.WriteLine($"R-Score: {rScore:F2}");
            Console.WriteLine("======================================================================");
        }



        internal double CalculateRScore()
        {
            throw new NotImplementedException();
        }
    }
}





















       