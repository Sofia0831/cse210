public class PromptGenerator
 {
    public  List<string>_prompts {get; set;} = new List<string>() 
    {
        "What is your biggest dream?",
        "What are you grateful for today?",
        "Describe your ideal day",  
        "What is a positive habit that would really like to cultivate?",
        "What is something you wish you had done today?",
        "Write about something that inspired you.",
        "What are you nervous or anxious about today?",
        "What did you learn today and how can you apply this knowledge?",
        "What challenges did you face today. How did you overcome them and what did you learn from it?",
        "What was a moment of joy that you experienced today?",
        "What was a small but significant detail that you noticed today?",
        "What could have gone differently?",
        "Tell me about an old friend you've lost touch with.",
        "Did something happen to make you sad?",
        "When was the last time you cried?",
        "Describe your typical day, from wake to sleep."
    };

    public string GetRandomPrompt() 
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string JournalPrompt = _prompts[index];
        return JournalPrompt;
;    }
    
}