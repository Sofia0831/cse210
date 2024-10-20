public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")   
    {
    }

    public void Run()
    {
        base.Start();

        Console.WriteLine("Let's begin the breathing exercise");
        Console.WriteLine();
        int breaths = GetDuration()/5;
        for (int i = 0; i < breaths; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(5);
            Console.WriteLine("Breathe out...");
            ShowCountdown(5);
            Console.WriteLine();
        }
        base.End();
    }
}