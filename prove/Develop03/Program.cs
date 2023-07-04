using System;

class Program
{
    static void Main(string[] args)
    {
       string scriptureText = "And they came to him and awoke him, saying, Master, Master, we perish. Then he arose, and rebuked the wind and the raging of the water: and they ceased, and there was a calm.";
        ScriptureReference scriptureRef = new ScriptureReference("Luke", 8, 24);
        Scripture scripture = new Scripture(scriptureRef, scriptureText);
        WordHider wordHider = new WordHider(scripture);

        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
        Console.WriteLine(scripture.GetFullScripture());

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            Console.Clear();
            wordHider.HideRandomWord();
            Console.WriteLine("\n");

            if (wordHider.IsScriptureHidden())
                break;
        }

        Console.WriteLine("Scripture hidden completely.");
        Console.ReadKey();
    }
       
}