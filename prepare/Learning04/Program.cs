using System;

class Program
{
    static void Main(string[] args)
    {
        string mathTopic = "Addition";
        string studentName1 = "Steven Jones";
        string section = "Section 3.1";
        string problems = "Problems 3 - 12";
        string writingTopic = "Adverbs";
        string title = "My Favorite Adverbs";
        string summary = "";
        string homeworkList = "";
        string writingAssignment = "";

        Assignment myAssignment = new Assignment(studentName1, mathTopic);

        summary = myAssignment.GetSummary();
        Console.WriteLine(summary);
        Console.WriteLine("");

        MathAssignment myMathAssignment = new MathAssignment(studentName1, mathTopic, section, problems);
        summary = myMathAssignment.GetSummary();
        homeworkList = myMathAssignment.getHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(homeworkList);
        Console.WriteLine("");

        WritingAssignment myWritingAssignment = new WritingAssignment(studentName1, writingTopic, title);
        summary = myWritingAssignment.GetSummary();
        writingAssignment = myWritingAssignment.GetWritingInformation();
        Console.WriteLine(summary);
        Console.WriteLine(writingAssignment);


    }
}