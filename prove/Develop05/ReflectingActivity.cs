public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        base.Start();

        DisplayPrompt();
        ShowCountdown(5);
        Console.WriteLine();

        Console.WriteLine("Now let's reflect on some questions about this experience:");
        int remainingTime = GetDuration();

        while (remainingTime > 0)
        {
            DisplayQuestions();
            int questionTime = 10;
            ShowCountdown(questionTime);
            remainingTime -= questionTime;
            Console.WriteLine();
        }

        base.End();
        ActivityLogger.LogActivityCompletion("Reflecting Activity");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Reflect on your prompt: {prompt}");
    }

    private void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"{question}");
    }


}