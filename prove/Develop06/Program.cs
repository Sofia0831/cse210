using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop06 World!");

        SimpleGoal goal = new SimpleGoal("Run Marathon", "Complete a full marathon", "1000");

        Console.WriteLine(goal.GetStringRepresentation());

        goal.RecordEvent();

        Console.WriteLine(goal.GetStringRepresentation());
    }
}