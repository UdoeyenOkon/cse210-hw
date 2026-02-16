using System;
using System.Collections.Generic;
using System.IO;
public class GoalManager
{
     private List<Goal> _goals;
        private int _score;

        public GoalManager(List<Goal> goals, int score)
        {
            _goals = goals;
            _score = score;
        }

        public void Start()
        {
            string choice = "";

            while (choice != "6")
            {
                DisplayPlayerInfo();
                          
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Record Event");
                Console.WriteLine("5. Load Goals");
                Console.WriteLine("6. Quit");
                Console.Write("Select choice: ");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": CreateGoal(); break;
                    case "2": ListGoalDetails(); break;
                    case "3": SaveGoals(); break;
                    case "4": RecordEvent(); break;
                    case "5": LoadGoals(); break;
                }
            }
        }

        public void DisplayPlayerInfo()
        {   
            Console.WriteLine("\n.......................................");
            Console.WriteLine($"You have {_score} points!");
            Console.WriteLine($"Your current Level is: {GetLevel()}, and");
            Console.WriteLine($"You are ranked as: '{GetRank()}'");
            Console.WriteLine(".........................................");
        }

        public void ListGoalDetails()
        {
            Console.WriteLine($"The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("Select a choice from the menu: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            string type = Console.ReadLine();

            

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is the short description of the goal? ");
            string desc = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
    
            if (type == "1")
            {
                _goals.Add(new SimpleGoal(name, desc, points, false));
            }
            else if (type == "2")
            {
                _goals.Add(new EternalGoal(name, desc, points));
            }
            else if (type == "3")
            {
                Console.Write("How many times does this goal need to be accomplished to get get a bonus point? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus amount for accomplishing the goal? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, desc, points, 0, target, bonus));
            }
        }

        public void RecordEvent()
        {
            ListGoalDetails();
            Console.Write("Which goal did you accomplish? ");
            int index = int.Parse(Console.ReadLine()) - 1;

            int earned = _goals[index].RecordEvent();
            _score += earned;

            Console.WriteLine($"You earned {earned} points!");
        }

        public void SaveGoals()
        {
            Console.Write("Enter a filename to save the goal: ");
            string file = Console.ReadLine();
            try
            {
                string projectPath = AppDomain.CurrentDomain.BaseDirectory;
                string fullPath = Path.Combine(projectPath, "..\\..\\..\\", file);
                fullPath = Path.GetFullPath(fullPath);
                
                using (StreamWriter writer = new StreamWriter(fullPath))
                // using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine(_score);
                    foreach (Goal goal in _goals)
                    {
                        writer.WriteLine(goal.GetStringRepresentation());
                    }
                }
                Console.WriteLine("Goals saved successfully.");
                Console.WriteLine("To: " + fullPath);
            }
               
            catch (Exception ex)
                {
                    Console.WriteLine("Error saving goals: " + ex.Message);
                }
        }

        public void LoadGoals()
        {
            Console.Write("Enter filename: ");
            string file = Console.ReadLine();

            string[] lines = File.ReadAllLines(file);

            _goals.Clear();
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");

                if (parts[0] == "SimpleGoal")
                {
                    _goals.Add(new SimpleGoal(parts[1], parts[2], parts[3], bool.Parse(parts[4])));
                }
                else if (parts[0] == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], parts[3]));
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                }
            }
        }

        private int GetLevel()
        {
            if (_score >= 2000) return 5;
            if (_score >= 1500) return 4;
            if (_score >= 1000) return 3;
            if (_score >= 500) return 2;
            return 1;
        }

        private string GetRank()
        {
            if (_score >= 2000) return "Pioneer";
            if (_score >= 1500) return "Active";
            if (_score >= 1000) return "Less Active";
            if (_score >= 500) return "Newly baptized";
            return "Investigator";
        }

}
