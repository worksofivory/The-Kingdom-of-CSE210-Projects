using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        List<SimpleGoal> simpleGoals = new List<SimpleGoal>();
        List<EternalGoal> eternalGoals = new List<EternalGoal>();
        List<ChecklistGoal> checklistGoals = new List<ChecklistGoal>();
        List<string> menu = new List<string>{
            "Create New Goal",
            "List Goals",
            "Save Goals",
            "Load Goals",
            "Record Event",
            "Quit"};
        List<string> goalMenu = new List<string>{
            "Simple Goal",
            "Eternal Goal",
            "Checklist Goal",
            "Return"
        };
        int menuInput = 0;
        int goalMenuInput = 0;
        int goalSelect = 0;
        string confirm = "";
        bool runMenu = true;
        bool runGoalMenu = false;
        bool runGoalSelect = false;
        bool runSubGoalSelect = false;
        while(runMenu){
            Console.Clear();
            int totalPoints = 0;
            foreach(SimpleGoal goal in simpleGoals){
                if(goal.getDone()){totalPoints += goal.getPoints();}}
            
            foreach(EternalGoal goal in eternalGoals){
                if(goal.getDone()){totalPoints += goal.getPoints()*goal.getTimesCompleted();}}
            
            foreach(ChecklistGoal goal in checklistGoals){
                totalPoints += goal.getPoints()*goal.getCompletions();
                if(goal.getDone()){totalPoints += goal.getBonusPoints();}}
            
            System.Console.WriteLine($"You have {totalPoints} points!");
            displayMenu(menu);
            System.Console.Write("What would you like to do?: ");
            menuInput = int.Parse(System.Console.ReadLine());
            if(menuInput == 1){
                runGoalMenu = true;
                while(runGoalMenu){
                    Console.Clear();
                    displayMenu(goalMenu);
                    goalMenuInput = int.Parse(Console.ReadLine());
                    if(goalMenuInput == 1){
                        Console.Clear();
                        SimpleGoal temp = new SimpleGoal();
                        System.Console.WriteLine("What would you like to call this goal?");
                        string name = Console.ReadLine();
                        System.Console.WriteLine("Write a description for this goal");
                        string desc = Console.ReadLine();
                        System.Console.WriteLine("How many points should this goal be worth?");
                        int points = int.Parse(Console.ReadLine());
                        temp.constructGoal(false, name, desc, points, 0, 0, 0);
                        simpleGoals.Add(temp);
                    }
                    if(goalMenuInput == 2){
                        Console.Clear();
                        EternalGoal temp = new EternalGoal();
                        System.Console.WriteLine("What would you like to call this goal?");
                        string name = Console.ReadLine();
                        System.Console.WriteLine("Write a description for this goal");
                        string desc = Console.ReadLine();
                        System.Console.WriteLine("How many points should this goal be worth?");
                        int points = int.Parse(Console.ReadLine());
                        temp.constructGoal(false, name, desc, points, 0, 0, 0);
                        eternalGoals.Add(temp);
                    }
                    if(goalMenuInput == 3){
                        Console.Clear();
                        ChecklistGoal temp = new ChecklistGoal();
                        System.Console.WriteLine("What would you like to call this goal?");
                        string name = Console.ReadLine();
                        System.Console.WriteLine("Write a description for this goal");
                        string desc = Console.ReadLine();
                        System.Console.WriteLine("How many times do you want to complete this goal?");
                        int completions = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("How many points should this goal be worth for each completion?");
                        int points = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("How many points do you want to earn when you finish completing this goal?");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        temp.constructGoal(false, name, desc, points, 0, completions, bonusPoints);
                        checklistGoals.Add(temp);
                    }
                    if(goalMenuInput == 4){runGoalMenu = false;}}}
            if(menuInput == 2){
                Console.Clear();
                System.Console.WriteLine("Simple Goals:");
                foreach(SimpleGoal goal in simpleGoals){goal.displayGoal();}
                System.Console.WriteLine("Eternal Goals:");
                foreach(EternalGoal goal in eternalGoals){goal.displayGoal();}
                System.Console.WriteLine("Checklist Goals:");
                foreach(ChecklistGoal goal in checklistGoals){goal.displayGoal();}
                System.Console.WriteLine("Hit enter to return to menu");
                Console.ReadLine();
            }
            if(menuInput == 3){
                Console.Clear();
                System.Console.Write("Enter the name of your file without the extension (it will always be a .txt): ");
                string filename = Console.ReadLine()+".txt";
                using(StreamWriter outputFile = new StreamWriter(filename)){
                foreach(SimpleGoal goal in simpleGoals){
                    outputFile.WriteLine($"Simple^{goal.getName()}^{goal.getDesc()}^{goal.getPoints()}^{goal.getDone()}");}
                foreach(EternalGoal goal in eternalGoals){
                    outputFile.WriteLine($"Eternal^{goal.getName()}^{goal.getDesc()}^{goal.getPoints()}^{goal.getDone()}^{goal.getTimesCompleted()}");}
                foreach(ChecklistGoal goal in checklistGoals){
                    outputFile.WriteLine($"Checklist^{goal.getName()}^{goal.getDesc()}^{goal.getPoints()}^{goal.getDone()}^{goal.getCompletions()}^{goal.getTimesToComplete()}^{goal.getBonusPoints()}");}
                } 
            }
            if(menuInput == 4){
                Console.Clear();
                System.Console.WriteLine("Do you have unsaved goals? (y/n)");
                confirm = Console.ReadLine();
                if(confirm.ToLower() == "y"){
                    menuInput = 3;
                }else{
                    simpleGoals = new List<SimpleGoal>();
                    eternalGoals = new List<EternalGoal>();
                    checklistGoals = new List<ChecklistGoal>();
                    System.Console.Write("Enter the name of the file you'd like to load without the extention (it will always be .txt): ");
                    string filename = Console.ReadLine()+".txt";
                    string[] lines = System.IO.File.ReadAllLines(filename);
                        foreach(string line in lines){
                            string[] parts = line.Split("^");
                            if(parts[0] == "Simple"){
                            SimpleGoal loadedGoal = new SimpleGoal();
                            loadedGoal.constructGoal(bool.Parse(parts[4]), parts[1], parts[2], int.Parse(parts[3]), 0, 0, 0);
                            simpleGoals.Add(loadedGoal);
                            }
                            if(parts[0] == "Eternal"){
                            EternalGoal loadedGoal = new EternalGoal();
                            loadedGoal.constructGoal(bool.Parse(parts[4]), parts[1], parts[2], int.Parse(parts[3]), 0, 0, 0);
                            loadedGoal.setCompleted(int.Parse(parts[5]));
                            eternalGoals.Add(loadedGoal);
                            }
                            if(parts[0] == "Checklist"){
                            ChecklistGoal loadedGoal = new ChecklistGoal();
                            loadedGoal.constructGoal(bool.Parse(parts[4]), parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                            checklistGoals.Add(loadedGoal);
                            }
                        }}      
            }
            if(menuInput == 5){
                runGoalSelect = true;
                while(runGoalSelect){
                    Console.Clear();
                    System.Console.WriteLine("Which goals would you like to access?");
                    displayMenu(goalMenu);
                    goalMenuInput = int.Parse(Console.ReadLine());
                    if(goalMenuInput == 1){
                        Console.Clear();
                        runSubGoalSelect = true;
                        while(runSubGoalSelect){
                            int spot = 0;
                            foreach(SimpleGoal goal in simpleGoals){
                                spot += 1;
                                System.Console.WriteLine($"{spot}. {goal.getName()}\nPoints:{goal.getPoints()}");
                            }                            
                            System.Console.WriteLine("Select a goal by its number to complete it: ");
                            goalSelect = int.Parse(Console.ReadLine());
                            simpleGoals[goalSelect -1].completeGoal();
                            System.Console.Write("Do you have more goals you want to complete? (y/n): ");
                            confirm = Console.ReadLine();
                            if(confirm.ToLower() == "y"){
                                runSubGoalSelect = true;
                            }else{
                                runSubGoalSelect = false;
                            }
                        }
                    }
                    if(goalMenuInput == 2){
                        Console.Clear();
                        runSubGoalSelect = true;
                        while(runSubGoalSelect){
                            int spot = 0;
                            foreach(EternalGoal goal in eternalGoals){
                                spot += 1;
                                System.Console.WriteLine($"{spot}. {goal.getName()}\nPoints:{goal.getPoints()} Times Completed: {goal.getTimesCompleted()}");
                            }                            
                            System.Console.WriteLine("Select a goal by its number to complete it: ");
                            goalSelect = int.Parse(Console.ReadLine());
                            eternalGoals[goalSelect -1].completeGoal();
                            System.Console.Write("Do you have more goals you want to complete? (y/n): ");
                            confirm = Console.ReadLine();
                            if(confirm.ToLower() == "y"){
                                runSubGoalSelect = true;
                            }else{
                                runSubGoalSelect = false;
                            }
                        }
                    }
                    if(goalMenuInput == 3){
                        Console.Clear();
                        runSubGoalSelect = true;
                        while(runSubGoalSelect){
                            int spot = 0;
                            foreach(ChecklistGoal goal in checklistGoals){
                                spot += 1;
                                System.Console.WriteLine($"{spot}. {goal.getName()}\nPoints:{goal.getPoints()}\nCompletions: {goal.getCompletions()}/{goal.getTimesToComplete()} Bonus Points: {goal.getBonusPoints()}");
                            }                            
                            System.Console.WriteLine("Select a goal by its number to complete it: ");
                            goalSelect = int.Parse(Console.ReadLine());
                            checklistGoals[goalSelect -1].smallCompletion();
                            if(checklistGoals[goalSelect -1].getCompletions() == checklistGoals[goalSelect-1].getTimesToComplete()){
                                System.Console.WriteLine("Congrats!!  You finished this goal!!");
                                checklistGoals[goalSelect -1].completeGoal();
                            }
                            System.Console.Write("Do you have more goals you want to complete? (y/n): ");
                            confirm = Console.ReadLine();
                            if(confirm.ToLower() == "y"){
                                runSubGoalSelect = true;
                            }else{
                                runSubGoalSelect = false;
                            }
                        }
                    }
                    if(goalMenuInput == 4){
                        Console.Clear();
                        runGoalSelect = false;
                    }}
            }
            if(menuInput == 6){runMenu = false;}}
    }
    public static void displayMenu(List<string> menu){
        int spot = 0;
        foreach(string item in menu){
            spot +=1;
            System.Console.WriteLine($"{spot}. {item}");
        }}
}