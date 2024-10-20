using System;
using System.Collections.Generic;

public abstract class Activity 
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Preparing to begin...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void SetDuration()
    {
        Console.Write("Enter the duration you want to spend doing this activity: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public int GetDuration()
    {
        return _duration;
    }

    private void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        SetDuration();  
    }

    public void End()
    {
        Console.WriteLine();
        Console.WriteLine("Great job, I'm proud of you!");
        ShowSpinner(3);
        Console.WriteLine($"Activity Completed: {_name}");
        Console.WriteLine($"Duration: {_duration} seconds");
        ShowSpinner(5);
        Console.WriteLine("Program Ended");
        Console.WriteLine();
    }


    public void ShowSpinner(int seconds)
    {
        Console.Write("Loading");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("");
    }
}