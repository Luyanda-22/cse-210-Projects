using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Durban", "Durban North","South Africa");
        Lecture lecture = new Lecture("Building Future Leaders", "Empowering the youth to take charge of their future and success", DateTime.Now, TimeSpan.FromHours(2), address1, "Ben and Gwen Kurst, Brian Shultz", 100);

        Address address2 = new Address("456 Elm St", "Braamfontein", "Johanneburg", "South Africa");
        Reception reception = new Reception("Giving back", "Putting together the crafts and arts to build or bake things we can give to people.", DateTime.Now, TimeSpan.FromHours(3), address2, "GiveHope.rsvp@gmail.com");

        Address address3 = new Address("789 Oaks Avenue", "Parktown", "Johannnesburg", "South Africa");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Music Mash", "Artists gathering to provide music to the crowd with tickets starting from as low as $50", DateTime.Now, TimeSpan.FromHours(4), address3, "Sunny");

        // Generate marketing messages for each event
        Console.WriteLine("Lecture Marketing Messages:");
        Console.WriteLine("---------------------------");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Marketing Messages:");
        Console.WriteLine("-----------------------------");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Marketing Messages:");
        Console.WriteLine("------------------------------------");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
    
    }
}