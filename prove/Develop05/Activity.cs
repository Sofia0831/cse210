public class Activity 
{
    private string _name;
    private string _description;
    private int _duration;

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

    private void SetDuration()
    {
        Console.Write("Enter the duration (in seconds) you want to spend doing this activity: ");
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
        Console.WriteLine();
        Console.WriteLine($"Activity Completed: {_name}");
        Console.WriteLine($"Duration: {_duration} seconds");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("Activity Ended");
        Console.WriteLine("Is there anything else you would like to do?");
        Console.WriteLine();
    }


    public void ShowSpinner(int seconds)
    {
        Console.Write("\rLoading ");

        DateTime startTime = DateTime.Now;
        while (DateTime.Now - startTime < TimeSpan.FromSeconds(seconds))
        {
            Console.Write("\rLoading -");
            Thread.Sleep(100);
            Console.Write("\rLoading \\");
            Thread.Sleep(100);
            Console.Write("\rLoading |");
            Thread.Sleep(100);
            Console.Write("\rLoading /");
            Thread.Sleep(100);

        }
        Console.Write("\r                ");
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