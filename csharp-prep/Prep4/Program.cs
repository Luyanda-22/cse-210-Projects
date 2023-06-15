using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
       
        List<int> numberList = new List<int>();

        int userNumber;

        while(true)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 0)
            {
                break;
            }

            numberList.Add(userNumber);
        }

        int sum = 0;
        foreach (int number in numberList)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");

        double average = (double)sum / numberList.Count;

        Console.WriteLine($"The average number is: {average}");

        int largestNumber = numberList.Max();
        Console.WriteLine($"The Largest number in the list is: {largestNumber}");


    }
}