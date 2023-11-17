class Scripture
{
    private string reference;
    private List<Word> words;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetReference()
    {
        return reference;
    }

    public string GetDisplayText()
    {
        return string.Join(" ", words.Select(word => word.IsHidden ? "___" : word.Text));
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        List<int> selectedIndices = new List<int>();

        int availableWordsCount = words.Count(w => !w.IsHidden);

        int wordsToHide = random.Next(1, availableWordsCount + 1);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index;
            do
            {
                index = random.Next(words.Count);
            } while (selectedIndices.Contains(index) || words[index].IsHidden);

            selectedIndices.Add(index);
            words[index].Hide();
        }
    }


    public bool HasHiddenWords()
    {
        return words.Any(w => !w.IsHidden);
    }
}