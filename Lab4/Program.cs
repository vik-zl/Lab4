using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ChamplainStudent> students = new List<ChamplainStudent>();
            string studentFilePath = "C:\\Users\\Vikit\\source\\repos\\Lab4\\Lab4\\students.txt";
            string courseFilePath = "C:\\Users\\Vikit\\source\\repos\\Lab4\\Lab4\\courses.txt";

            if (!File.Exists(studentFilePath))
            {
                Console.WriteLine("The file 'students.txt' was not found.");
                return;
            }
            if (!File.Exists(courseFilePath))
            {
                Console.WriteLine("The file 'courses.txt' was not found.");
                return;
            }

            var studentLines = File.ReadAllLines(studentFilePath);
            foreach (var line in studentLines)
            {
                var parts = line.Split(',');
                if (parts.Length < 13)
                {
                    Console.WriteLine($"Invalid data format: {line}");
                    continue;
                }
                try
                {
                    ChamplainStudent student = new ChamplainStudent
                    {
                        name = parts[0],
                        age = int.TryParse(parts[1], out int ageVal) ? ageVal : 0,
                        gender = parts[2],
                        DateofBirth = DateTime.TryParseExact(parts[3], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dobVal) ? dobVal : DateTime.MinValue,
                        StudentID = int.TryParse(parts[4], out int idVal) ? idVal : 0,
                        YearOfRegistration = int.TryParse(parts[5], out int yearVal) ? yearVal : 0,
                        Zscore = double.TryParse(parts[6], out double zVal) ? zVal : 0.0,
                        StudentIds = string.IsNullOrWhiteSpace(parts[7]) ? new List<int>() : parts[7].Split(';').Where(s => int.TryParse(s, out _)).Select(int.Parse).ToList(),
                        CourseId = string.IsNullOrWhiteSpace(parts[8]) ? new List<string>() : parts[8].Split(';').ToList(),
                        CourseName = string.IsNullOrWhiteSpace(parts[9]) ? new List<string>() : parts[9].Split(';').ToList(),
                        Score = string.IsNullOrWhiteSpace(parts[10]) ? new List<double>() : parts[10].Split(';').Where(s => double.TryParse(s, out _)).Select(double.Parse).ToList(),
                        GroupId = string.IsNullOrWhiteSpace(parts[11]) ? new List<string>() : parts[11].Split(';').ToList(),
                        IRG = string.IsNullOrWhiteSpace(parts[12]) ? new List<int>() : parts[12].Split(';').Where(s => int.TryParse(s, out _)).Select(int.Parse).ToList()
                    };
                    students.Add(student);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error parsing line: {line}\n{ex.Message}");
                }
            }

            Console.WriteLine("Champlain Student Grading Report");
            Console.WriteLine(new string('=', 40));
            foreach (var student in students)
            {
                double avg = student.CalculateAverage();
                double gpa = student.CalculateGPA();
                double rscore = student.CalculateRScore();

                Console.WriteLine($"Student: {student.name} (ID: {student.StudentID})");
                Console.WriteLine($"  Average: {avg:F2}");
                Console.WriteLine($"  GPA: {gpa:F2}");
                Console.WriteLine($"  R-Score: {rscore:F2}");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}

