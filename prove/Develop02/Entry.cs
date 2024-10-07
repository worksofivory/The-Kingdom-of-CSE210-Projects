public class Entry{
    public DateTime _date;
    public string _content;
    public string _prompt;

    public void displayEntry(){
        System.Console.WriteLine($"{_date}");
        System.Console.WriteLine($"{_prompt}");
        System.Console.WriteLine($"{_content}");
    }
}