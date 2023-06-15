using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(userName, squaredNumber);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favourite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;      
        }

        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }

        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }
    }
}