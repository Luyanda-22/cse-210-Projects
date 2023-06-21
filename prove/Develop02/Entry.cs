public class Entry
{
    public string date, question, userEntry;
    
    public Entry (string _date, string _question, string _userEntry)
    {
        date        =  _date;
        question    =  _question;
        userEntry   =  _userEntry;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {date} - Prompt: {question}");
        Console.WriteLine(userEntry);
    }
}