using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square();
        s.SetColor("red");
        Console.WriteLine(s.GetColor());
        Console.WriteLine(s.GetArea());


    }
}