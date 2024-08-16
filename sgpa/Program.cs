using System;
using System.Collections.Generic;

class UserInputGrades
{
    static void Main(string[] args)
    {
        Dictionary<string, (int Credit, string Grade)> subjectGrades = new Dictionary<string, (int, string)>();

        Console.WriteLine("Enter Student Name:");
        string studentName = Console.ReadLine();

        Console.WriteLine("Enter Register Number:");
        string registerNumber = Console.ReadLine();

        int numberOfSubjects;
        Console.Write("Enter the number of subjects: ");
        if (!int.TryParse(Console.ReadLine(), out numberOfSubjects) || numberOfSubjects <= 0)
        {
            Console.WriteLine("Invalid input for number of subjects. Please enter a valid positive number.");
            return;
        }

        double totalGradePoints = 0.0;
        int totalCreditHours = 0;

        for (int i = 0; i < numberOfSubjects; i++)
        {
            Console.WriteLine($"\nEnter details for subject {i + 1}:");
            Console.Write("Subject name: ");
            string subjectName = Console.ReadLine().Trim();

            Console.Write("Credit: ");
            if (!int.TryParse(Console.ReadLine().Trim(), out int credit) || credit <= 0)
            {
                Console.WriteLine("Invalid input for credit. Please enter a valid positive number.");
                i--;
                continue;
            }

            Console.Write("Grade: ");
            string grade = Console.ReadLine().Trim().ToUpper();

            if (!IsValidGrade(grade))
            {
                Console.WriteLine("Invalid grade entered for {0}. Please enter a valid grade.", subjectName);
                i--;
                continue;
            }

            subjectGrades[subjectName] = (credit, grade);

            totalCreditHours += credit;
            totalGradePoints += GetGradePoint(grade) * credit;
        }

        Console.WriteLine($"\nStudent Name: {studentName} Register Number: {registerNumber}");
        Console.WriteLine("\nSubjects, Credits, and Grades:");

        foreach (var (subject, (credit, grade)) in subjectGrades)
        {
            Console.WriteLine($"{subject}: {grade} ({credit})");
        }

        double sgpa = totalGradePoints / totalCreditHours;
        Console.WriteLine($"\nSGPA: {sgpa:F2}");
    }

    static bool IsValidGrade(string grade)
    {
        return grade == "S" || grade == "A" || grade == "B" || grade == "C" || grade == "D" || grade == "E";
    }

    static double GetGradePoint(string grade)
    {
        switch (grade)
        {
            case "S":
                return 10.0;
            case "A":
                return 9.0;
            case "B":
                return 8.0;
            case "C":
                return 7.0;
            case "D":
                return 6.0;
            case "E":
                return 5.0;
            default:
                return 0.0; // Invalid grade
        }
    }
}
