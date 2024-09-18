using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letter = "";

        int rem = grade % 10;
        string sign = "";


        if (grade >= 90)
        {
            letter = "A";
            if (rem < 3)
            {
                sign = "-";
            }
            else if (rem == 0)
            {
                sign = "";
            }
        }
        else if (grade >= 80)
        {
            letter = "B";
            if (rem >= 7)
            {
                sign = "+";
            }
            else if (rem < 3)
            {
                sign = "-";
            }
            else if (rem == 0)
            {
                sign = "";
            }
        }
        else if (grade >= 70)
        {
            letter = "C";
            if (rem >= 7)
            {
                sign = "+";
            }
            else if (rem < 3)
            {
                sign = "-";
            }
            else if (rem == 0)
            {
                sign = "";
            }
        }
        else if (grade >= 60)
        {
            letter = "D";
            if (rem >= 7)
            {
                sign = "+";
            }
            else if (rem < 3)
            {
                sign = "-";
            }
            else if (rem == 0)
            {
                sign = "";
            }
        }
        else
        {
            letter = "F";
            sign = "";
        }



        Console.WriteLine($"Your letter grade is {letter}{sign}");
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else 
        {
               Console.WriteLine("You did not pass. Better luck next time!");
            }

    }
}