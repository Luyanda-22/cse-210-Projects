using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What gade percentage did you get on your last exam?");
        string number = Console.ReadLine();
        int percentage = int.Parse(number);

        string letter; 

        if (percentage >= 90)
        {
            letter = "A";
        }

        else if (percentage >= 80)
        {
            letter = "B";
        }

        else if (percentage >= 70)
        {
            letter = "C";
        }

        else if (percentage >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        Console.WriteLine($"The letter grade is: {letter}.");

        if (percentage >=70)
        {
            Console.WriteLine("Congradulations! You passed the exam.");
        }

        else
        {
            Console.WriteLine("Study hard next time champ.");
        }


    }
}