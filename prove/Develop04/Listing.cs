public class Listing : Activity{
    List<string> _listPrompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"};
    List<string> _listedItems = new List<string>();

    public Listing(string name, string description) : base(name, description){

    }
    public void intro(){
        Random randomGenerator = new Random();
        int _promptsLength = _listPrompts.Count;
        int spot = randomGenerator.Next(0, _promptsLength);
        System.Console.WriteLine("Your prompt for this session is:");
        System.Console.WriteLine(_listPrompts[spot]);
        playAnimation();
    }
    public void listItems(int duration){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        string input = "";
        while(DateTime.Now < endTime){
            input = Console.ReadLine();
            _listedItems.Add(input);
        }
    }
    public string runListing(){
        int duration = startActivity();
        intro();
        listItems(duration);
        System.Console.WriteLine($"You listed {_listedItems.Count()} items!");
        return endActivity();
    }
}