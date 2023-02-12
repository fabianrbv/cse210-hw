using System;

public class Reference
{
    public string _book;
    public string _chapter;
    public string _verse;

    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }
}