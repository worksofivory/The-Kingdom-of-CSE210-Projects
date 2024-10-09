using System.IO;
public class Journal{
    List<string> _prompts = new List<string> {
    "What was the most memorable part of today?",
    "What was frustrating about today?",
    "What was uplifting about today?",
    "What made today a good day?",
    "What's something you were grateful for today?"};
    List<Entry> _entries = new List<Entry>();

    public void inputEntry(){
        Entry unsaved = new Entry();
        string tempPrompt = displayPrompt();
        string entryInput = Console.ReadLine();
        unsaved._content = entryInput;
        unsaved._prompt = tempPrompt;
        unsaved._date = DateTime.Now;
        _entries.Add(unsaved);
    }
    public string displayPrompt(){
        //generate a random number to pull from the prompts list and display
        Random randomGenerator = new Random();
        int _promptsLength = _prompts.Count;
        int spot = randomGenerator.Next(0, _promptsLength);
        System.Console.WriteLine(_prompts[spot]);
        return _prompts[spot];
    }
    public void displayJournal(){
        //loop through entries and display each entry in the list
        foreach(Entry entry in _entries){
            entry.displayEntry();
        }
    }
    public void writeEntries(){
        System.Console.Write("Enter the name of your file: ");
        string filename = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter(filename)){
            foreach(Entry entry in _entries){
                outputFile.WriteLine($"{entry._date}+{entry._prompt}+{entry._content}");
            }
        }
    }
    public void readEntries(){
        _entries = new List<Entry>();
        System.Console.Write("Enter the name of the file you'd like to load: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines){
            string[] parts = line.Split("+");
            Entry loadedEntry = new Entry();
            loadedEntry._date = DateTime.Parse(parts[0]);
            loadedEntry._prompt = parts[1];
            loadedEntry._content = parts[2];
            _entries.Add(loadedEntry);
        }
    }
}