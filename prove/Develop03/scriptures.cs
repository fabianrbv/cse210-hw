using System;

public class Scripture
{
    public List<string> _scripture = new List<string>{
        "For ", "God ", "so ", "loved ", "the ", "world, ", "that ", "he ", "gave ", 
        "his ", "only ", "begotten ", "Son, ", "\nthat ", "whosoever ", "believeth ", 
        "in ", "him ", "should ", "not ", "perish, ", "but ", "have ", "everlasting ", 
        "life."
    };

    public void Display()
    {
        foreach (string elemento in _scripture)
        {
            Console.Write(elemento);
        }
    }
}