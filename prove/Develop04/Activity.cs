public class Activity{
    string _name;
    int _duration;
    string _description;

    public Activity(string name, string description){
        _name = name;
        _description = description;
        _duration = 0;
    }
    public int setDuration(){
        int userInput;
        System.Console.Write("How long should this activity last?  Set the duration in seconds: ");
        userInput = int.Parse(Console.ReadLine());
        _duration = userInput;
        System.Console.Write("Get Ready");
        Thread.Sleep(1000);
        System.Console.Write(".");
        Thread.Sleep(1000);
        System.Console.Write(".");
        Thread.Sleep(1000);
        System.Console.WriteLine(".");
        Thread.Sleep(1000);
        System.Console.WriteLine("Start!");
        return userInput;
    }
    public string getDescription(){
        return _description;
    }
    public int getDuration(){
        return _duration;
    }
    public void playAnimation(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        while(DateTime.Now < endTime)
            {Console.Write("-"); 
            Thread.Sleep(300);
            Console.Write("\b \b"); 

            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b"); 
            
            Console.Write("|"); 
            Thread.Sleep(300);
            Console.Write("\b \b"); 
            
            Console.Write("/"); 
            Thread.Sleep(300);
            Console.Write("\b \b");
            }
    }
    public void displayTimer(int duration){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        int total = duration;
        while(DateTime.Now < endTime){
            Console.Write($"{total}");
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
            total -= 1;
        }
    }
    public int startActivity(){
        System.Console.WriteLine(_description);
        int duration = setDuration();
        return _duration;
    }
    public string endActivity(){
        System.Console.WriteLine("Well Done!");
        playAnimation();
        System.Console.WriteLine($"Congrats! You just completed another {_duration} seconds of the {_name} Activity!");
        playAnimation();
        System.Console.Write("Would you like to do another activity? (Y/N): ");
        string confirm = "";
        confirm = System.Console.ReadLine();
        return confirm;
    }
}