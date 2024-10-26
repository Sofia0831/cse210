using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop06 World!");

        SimpleGoal goal = new SimpleGoal("Run Marathon", "Complete a full marathon", 1000);
        Console.WriteLine(goal.GetStringRepresentation());
        goal.RecordEvent();


        EternalGoal goal2 = new EternalGoal("Read the Scriptures", "Read the scriptures for at least 10 minutes", 50);
        Console.WriteLine(goal2.GetStringRepresentation());
        goal2.RecordEvent();

        Console.WriteLine();

        Console.WriteLine(goal.GetStringRepresentation());
        Console.WriteLine(goal2.GetStringRepresentation());

    }
}