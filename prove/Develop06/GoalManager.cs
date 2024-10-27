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
            Console.WriteLine("6. Quit");
            Console.Write("Select an option from the menu (1-6): ");

             int choice;
             while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
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

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
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

    public void SaveEvent()
    {
        Console.WriteLine("Enter a name for your file: ");
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
        Console.WriteLine("Enter the name of your file: ");
        string userName = Console.ReadLine();
        string fileName = userName + ".txt";

        try
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            // Read the total from the first line
            string totalLine = reader.ReadLine();
            int total = int.Parse(totalLine);

            // Clear the existing goals list before loading new ones
            _goals.Clear();

            // Read the rest of the lines, each representing a Goal
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Parse the line to create a Goal object based on the type
                string[] goalData = line.Split(',');

                // Identify the goal type based on the first element in the data
                string goalType = goalData[0];

                Goal goal;
                switch (goalType)
                {
                    case "Simple Goal":
                        goal = new SimpleGoal(goalData[1], goalData[2], int.Parse(goalData[3]));
                        break;
                    case "Eternal Goal":
                        goal = new EternalGoal(goalData[1], goalData[2], int.Parse(goalData[3]));
                        break;
                    case "Checklist Goal":
                        goal = new CheckListGoal(goalData[1], goalData[2], int.Parse(goalData[3]), int.Parse(goalData[4]), int.Parse(goalData[5]));
                        break;
                    default:
                        Console.WriteLine($"Warning: Unknown goal type: {goalType}");
                        continue; // Skip to the next line if unknown type
                }

                // Add the created goal to the _goals list
                _goals.Add(goal);
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Please check the filename and try again.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error parsing file. Please ensure the file format is correct.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while loading goals: " + ex.Message);
    }

    
    }
}