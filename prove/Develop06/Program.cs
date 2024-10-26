using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop06 World!");

        // SimpleGoal goal = new SimpleGoal("Run Marathon", "Complete a full marathon", 1000);
        // Console.WriteLine(goal.GetStringRepresentation());
        // goal.RecordEvent();


        // EternalGoal goal2 = new EternalGoal("Read the Scriptures", "Read the scriptures for at least 10 minutes", 50);
        // Console.WriteLine(goal2.GetStringRepresentation());
        // goal2.RecordEvent();

        // CheckListGoal goal3 = new CheckListGoal("Attend the temple", "Attend and perform any ordinance", 50, 3, 100);
        // Console.WriteLine(goal3.GetStringRepresentation());
        // goal3.RecordEvent();
        // goal3.RecordEvent();
        // goal3.RecordEvent();

        // Console.WriteLine();

        // Console.WriteLine(goal.GetStringRepresentation());
        // Console.WriteLine(goal2.GetStringRepresentation());
        // Console.WriteLine(goal3.GetStringRepresentation());

        // Console.WriteLine(goal.GetDetailString());

        GoalManager manager = new GoalManager();
        manager.Start();

    }
}