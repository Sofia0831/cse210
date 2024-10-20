using System.Xml;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people you appreciate?",
            "What are personal strengths of yours",
            "Think of the people who you were able to help this week.",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "Think of anything that you are grateful for no matter how small"
        };
    }

    public void Run()
    {
        base.Start();

        string prompt = GetRandomPrompt();

        Console.WriteLine($"Reflect on the prompt: {prompt}");
        ShowCountdown(10);

        Console.WriteLine("Start listing down what you have reflected:");
        List<string> responses = GetListFromUser();

        int totalItems = responses.Count;
        Console.WriteLine($"You listed {totalItems} items.");

        base.End();
    }

    public string GetRandomPrompt()
    {
         Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;

        while (DateTime.Now - startTime < TimeSpan.FromSeconds(GetDuration()))
        {
            Console.Write("Enter your list: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        return items;
    }
}

