public class Prompt
{
    List<string> questions;

    public Prompt()
    {
        questions = new List<string>
        {
            "Who was the most inteesting person I interacted with today?",
            "WHat was the best part of my day?",
            "How did I see the strongest emotion I felt today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }
  
    public string GetPrompt()
    {
        string randomQuestion = "";
        int randomIndex = new Random().Next(questions.Count);

        randomQuestion = questions[randomIndex];

        return randomQuestion;
    }

    public void Display()
    {
        
    }
}