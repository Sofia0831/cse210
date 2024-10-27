using System;
using System.IO;

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
            Console.WriteLine("6. Delete Goal");
            Console.WriteLine("7. Quit");
            Console.Write("Select an option from the menu (1-7): ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                Console.Write("Select an option from the menu (1-7): ");
            }

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
                    DeleteGoal();
                    break;
                case 7:
                    Console.WriteLine("Thank you for using the program!");
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
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals to show yet.");
        }
        else
        {
            Console.WriteLine();
        Console.WriteLine("Your list of goals: ");
        int index = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{index++}. {goal.GetName()}");
        }
        }
    
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals to show yet.");
        }
        else
        {
            Console.WriteLine();
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Never mind");
        Console.Write("Choose a type of goal to create: ");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            Console.Write("Choose a type of goal to create: ");
        }

        switch (choice)
        {
            case 1:
                Console.Write("Enter goal name: ");
                string simpleName = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string simpleDescription = Console.ReadLine();

                int simplePoints;
                while (true)
                {
                    Console.Write("Enter points for completion: ");
                    string input = Console.ReadLine();
    
                    if (int.TryParse(input, out simplePoints))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }
                _goals.Add(new SimpleGoal(simpleName,simpleDescription, simplePoints));
                break;
            case 2:
                Console.Write("Enter goal name: ");
                string eternalName = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string eternalDescription = Console.ReadLine();

                int eternalPoints;
                while (true)
                {
                    Console.Write("Enter points per event: ");
                    string input = Console.ReadLine();
    
                    if (int.TryParse(input, out eternalPoints))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }
                _goals.Add(new EternalGoal(eternalName, eternalDescription, eternalPoints));
                break;
            case 3:
                Console.Write("Enter goal name: ");
                string checklistName = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string checklistDescription = Console.ReadLine();

                int checklistPoints;
                while (true)
                {
                    Console.Write("Enter points for completion: ");
                    string input = Console.ReadLine();
    
                    if (int.TryParse(input, out checklistPoints))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }

                int checklistTarget;
                while (true)
                {
                    Console.Write("Enter target completions: ");
                    string input = Console.ReadLine();
    
                    if (int.TryParse(input, out checklistTarget))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }

                int checklistBonus;
                while (true)
                {
                    Console.Write("Enter bonus points for completion: ");
                    string input = Console.ReadLine();
    
                    if (int.TryParse(input, out checklistBonus))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }

                _goals.Add(new CheckListGoal(checklistName, checklistDescription, checklistPoints, checklistTarget, checklistBonus));
                break;

            case 4:
                Console.WriteLine("Goal creation canceled.");
                return;

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

    public void SetTotal(int totalScore)
    {
        _score = totalScore;
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
        }
        else 
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

                    Console.WriteLine($"Event recorded successfully! You earned {_goals[input].GetPoints()} points!");

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

    
    }

    public void SaveEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals to save.");
            return;
        }

        Console.Write("Enter a name for your file: ");
        string userName = Console.ReadLine();
        string fileName = userName + ".txt";

        using (StreamWriter savedFile = new StreamWriter(fileName))
        {
            savedFile.WriteLine(GetTotal());

            foreach (Goal goal in _goals)
            {
                savedFile.WriteLine(goal.SaveGoal());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("Enter the name of your file: ");
        string userName = Console.ReadLine();
        string fileName = userName + ".txt";

        if (File.Exists(fileName))
        {
            string[] readText = File.ReadAllLines(fileName);

            int totalScore = int.Parse(readText[0]);
            SetTotal(totalScore);

            readText = readText.Skip(1).ToArray();

            foreach (string line in readText)
            {
                string[] data = line.Split(", ");

                string type = data[0];
                string name = data[1];
                string description = data[2];
                int points = int.Parse(data[3]);
                bool status = Convert.ToBoolean(data[4]);

                if (data[0] == "Simple Goal:")
                {
                    SimpleGoal simple = new SimpleGoal(name, description, points, status);
                    _goals.Add(simple);
                }
                if (data[0] == "Eternal Goal:")
                {
                    int count = int.Parse(data[5]);
                    EternalGoal eternal = new EternalGoal(name, description, points, count);
                    _goals.Add(eternal);
                }
                if (data[0] == "Checklist Goal:")
                {
                    int target = int.Parse(data[5]);
                    int bonus = int.Parse(data[6]);
                    int count = int.Parse(data[7]);
                    CheckListGoal checkList = new CheckListGoal(name, description, points, status, target, bonus, count);
                    _goals.Add(checkList);
                }
            }
        }
    
    }

    // Added option to delete a goal
    public void DeleteGoal()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals to delete.");
            return;
        }

        ListGoalNames();

        Console.Write("Enter the number of the goal you want to delete: ");
        int index;
        while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > _goals.Count)
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
        }

        _goals.RemoveAt(index - 1);
        Console.WriteLine("Goal deleted successfully.");

    }
}
