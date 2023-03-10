using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Enter the top number");
        // string _top = Console.ReadLine();
        // Console.WriteLine("Enter the bottom number");
        // string _bottom = Console.ReadLine();
        
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString("1", "0"));
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString("5", "0"));
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString("3","4"));
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString("1","3"));
        Console.WriteLine(f4.GetDecimalValue());
    }
}