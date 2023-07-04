class WordHider
{
    private Scripture scripture;
    private Random random;
    private List<int> hiddenWordIndices;

    public WordHider(Scripture scripture)
    {
        this.scripture = scripture;
        random = new Random();
        hiddenWordIndices = new List<int>();
    }

    public void HideRandomWord()
    {
        int totalWords = scripture.GetFullScripture().Split(' ').Length;
        int wordIndex;

        //Generate a random word index until a non-hidden word is found
        do
        {
            wordIndex = random.Next(totalWords);
        } while (hiddenWordIndices.Contains(wordIndex));

        hiddenWordIndices.Add(wordIndex);

        // Hide the word at the randomly selected index
        string hiddenScripture = scripture.HideWord(wordIndex);
        Console.WriteLine(hiddenScripture);
    }

    // CHecks if all the words in the scripture hae been hidden.
    public bool IsScriptureHidden()
    {
        return hiddenWordIndices.Count == scripture.GetFullScripture().Split(' ').Length;
    }
}
