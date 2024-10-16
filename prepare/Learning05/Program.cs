using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment();
        assignment.SetStudentName("Samuel Bennet");
        assignment.SetTopic("Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();
        
        MathAssignment math1 = new MathAssignment();
        math1.SetStudentName("Roberto Rodriguez");
        math1.SetTopic("Fractions");
        math1.SetTextBook("Section 7.3");
        math1.SetProblem("8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomework());
        Console.WriteLine();

        WritingAssignment writing1 = new WritingAssignment();
        writing1.SetStudentName("Mary Waters");
        writing1.SetTopic("European History");
        writing1.SetTitle("The Causes of World War II");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInfo());
    }
}