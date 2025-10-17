using Lab4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

try
{
    string studentFilePath = "C:\\Users\\Vikit\\source\\repos\\Lab4\\Lab4\\students.txt";
    string courseFilePath = "C:\\Users\\Vikit\\source\\repos\\Lab4\\Lab4\\courses.txt";

    string[] stuFileText = File.ReadAllLines(studentFilePath);
    string[] couFileText = File.ReadAllLines(courseFilePath);


    Console.WriteLine("Champlain College Report");
    Console.WriteLine();

    List<ChamplainStudent> students = new List<ChamplainStudent>();

    foreach (string line in stuFileText.Skip(1)) // Skip the header line
    {
        string[] parts = line.Split(',');

        // make sure there are enough fields in the line
        if (parts.Length < 7)
        {
            Console.WriteLine($"Skipping invalid student line: {line}");
            continue;
        }

        ChamplainStudent student = new ChamplainStudent();

        // safer parsing — prevents crashes if data is malformed
        if (int.TryParse(parts[0], out int id))
            student.StudentID = id;
        else
            Console.WriteLine($"Invalid StudentID in line: {line}");

        student.name = parts[1];  // assuming your property is 'Name'

        if (int.TryParse(parts[2], out int age))
            student.age = age;

        if (DateTime.TryParse(parts[3], out DateTime dob))
            student.DateofBirth = dob;

        if (char.TryParse(parts[4], out char gender))
            student.gender = gender.ToString();

        if (int.TryParse(parts[5], out int year))
            student.YearOfRegistration = year;

        if (double.TryParse(parts[6], out double z))
            student.Rscore = z;

        students.Add(student);
    }


    foreach (string line in couFileText.Skip(1)) // Skip the header line
    {
        string[] parts = line.Split(',');
        int studentID = int.Parse(parts[0]);
        ChamplainStudent student = students.FirstOrDefault(s => s.StudentID == studentID);
        if (student != null)
        {
            student.CourseId.Add(parts[1]);
            student.CourseName.Add(parts[2]);
            student.Score.Add(double.Parse(parts[3]));
            student.GroupId.Add(parts[4]);
            student.IRG.Add(int.Parse(parts[5]));
        }

    }
    foreach (ChamplainStudent student in students)
    {
        student.DisplayInfo();
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Could not find file: {ex.FileName}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Invalid data format: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}
finally
{
    Console.WriteLine("\nProcess complete. Press any key to exit...");
    Console.ReadKey();
}
