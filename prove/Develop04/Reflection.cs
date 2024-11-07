public class Reflection : Activity{
    private List<string> _prompt = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _promptQuestions = new List<string>{
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
    private Random _randomGenerator = new Random();
    public Reflection(string name, string description) : base(name, description){}

    public void reflect(){
        int _promptsLength = _prompt.Count;
        int spot = _randomGenerator.Next(0, _promptsLength);
        System.Console.WriteLine("Consider the following prompt:");
        System.Console.WriteLine($"---{_prompt[spot]}---");
        playAnimation();
        System.Console.WriteLine("Press the enter key when you're ready!");
        Console.ReadLine();
    }
    public void prompt(int duration){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        int listLength = _promptQuestions.Count;
        string input = "";
        System.Console.WriteLine("Now ponder on these questions as they are related to this experience.");
        System.Console.Write("You may begin in ");
        displayTimer(5);
        Console.Clear();    
        while(DateTime.Now < endTime){
            int spot = _randomGenerator.Next(0, listLength);
            System.Console.WriteLine($"> {_promptQuestions[spot]}");
            input = Console.ReadLine();
        }
    }
    public string runReflection(){
        int duration = startActivity();
        reflect();
        prompt(duration);
        return endActivity();
    }
}