public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Goal Tracker Program!");

        while (true)
        {
            Console.WriteLine();
            DisplayPLayerInfo();
            Console.WriteLine();
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option from the menu (1-6): ");

             int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        ListGoalDetails();
                        break;
                    case 3:
                        SaveEvent();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
        }

    }

    public void DisplayPLayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine();
        Console.WriteLine("Your list of goals: ");
        int index = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{index++}. {goal.GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine();
        foreach(var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose a type of goal to create: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter goal name: ");
                string simpleName = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string simpleDescription = Console.ReadLine();
                Console.Write("Enter points for completion: ");
                int simplePoints = int.Parse(Console.ReadLine());
                _goals.Add(new SimpleGoal(simpleName,simpleDescription, simplePoints));
                break;
            case 2:
                Console.Write("Enter goal name: ");
                string eternalName = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string eternalDescription = Console.ReadLine();
                Console.Write("Enter points per event: ");
                int eternalPoints = int.Parse(Console.ReadLine());
                _goals.Add(new EternalGoal(eternalName, eternalDescription, eternalPoints));
                break;
            case 3:
                Console.Write("Enter goal name: ");
                string checklistName = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string checklistDescription = Console.ReadLine();
                Console.Write("Enter points per completion: ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter target completions: ");
                int checklistTarget = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completion: ");
                int checklistBonus = int.Parse(Console.ReadLine());
                _goals.Add(new CheckListGoal(checklistName, checklistDescription, checklistPoints, checklistTarget, checklistBonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

    }

    public void AddPoints(int points)
    {
        _score += points;
    }

    public int GetTotal()
    {
        return _score;
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int input = int.Parse(Console.ReadLine()) - 1;

        
    if (input >= 0 && input < _goals.Count)
    {
        if (!_goals[input].IsComplete())
        {
            _goals[input].RecordEvent(_goals);
            _score += _goals[input].GetPoints();

            Console.WriteLine($"Event recorded successfully! You earned {_score} points!");

            // Check for bonus points for completed checklist goals
            if (_goals[input] is CheckListGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.GetBonusPoints();
                Console.WriteLine($"Congratulations! You've completed the checklist goal and earned a bonus of {checklistGoal.GetBonusPoints()} points.");
            }
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }

    }
    else
    {
        Console.WriteLine("Invalid index.");
    }
    
    }

    public void SaveEvent()
    {

    }

    public void LoadGoals()
    {
        
    }
}