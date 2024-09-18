using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {

            Console.Write("Enter number: ");
            string inputNum = Console.ReadLine();
            number = int.Parse(inputNum);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        int smallestPositive = numbers.Where(num => num > 0).Min();
        if (smallestPositive == 0)
        {
            Console.WriteLine("There are no positive numbers in the array.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        

    }
    
}
    