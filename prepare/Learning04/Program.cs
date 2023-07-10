using System;

class Program
{
    static void Main(string[] args)
    {
        //Assignment assignment = new Assignment(" Mary-Ann Smith", "Addition and Subtraction");

       // string summary = assignment.GetSummary();
       // Console.WriteLine(summary);

        string assignmentDetails = "Section 10.5 problems 1-20";

        MathAssignment mathAssignment = new MathAssignment("mary-Ann Smith", "Addition and Subtraction", assignmentDetails);

        string summary = mathAssignment.GetSummary();
        Console.WriteLine(summary);

        string assignmentDetailsString = mathAssignment.GetAssignmentDetails();
        Console.WriteLine(assignmentDetailsString);

        Console.WriteLine();

        string writingInformation = "Write a persuasive essay on climate change.";

        WritingAssignment writingAssignment = new WritingAssignment("Mary-Ann Smith", "Global Warming", writingInformation);

        string writingSummary = writingAssignment.GetSummary();
        Console.WriteLine(writingSummary);

        string writingInfo = writingAssignment.getWritingInformation();
        Console.WriteLine(writingInfo);
    }
}