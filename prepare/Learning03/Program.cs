using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);

        Console.WriteLine(f1.GetFractionString()); // 1/1
        Console.WriteLine(f1.GetDecimalValue());   // 1

        Console.WriteLine(f2.GetFractionString()); // 5/1
        Console.WriteLine(f2.GetDecimalValue());   // 5

        Console.WriteLine(f3.GetFractionString()); // 3/4
        Console.WriteLine(f3.GetDecimalValue());   // 0.75

        Fraction f4 = new Fraction();
        f4.SetTop(1);
        f4.SetBottom(3);
        Console.WriteLine(f4.GetTop()); // 1
        Console.WriteLine(f4.GetBottom()); // 3
        Console.WriteLine(f4.GetFractionString()); // 1/3
        Console.WriteLine(f4.GetDecimalValue()); // 0.33


    }
}