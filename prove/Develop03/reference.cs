class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    public Reference(string reference)
    {
        string[] parts = reference.Split(' ', ':', '-');

        book = parts[0];
        chapter = int.Parse(parts[1]);

        if (parts.Length == 3)
        {
            startVerse = int.Parse(parts[2]);
            endVerse = startVerse;
        }
        else if (parts.Length == 5)
        {
            startVerse = int.Parse(parts[2]);
            endVerse = int.Parse(parts[4]);
        }
    }

    public override string ToString()
    {
        if (startVerse == endVerse)
        {
            return $"{book} {chapter}:{startVerse}";
        }
        else
        {
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        }
    }
}