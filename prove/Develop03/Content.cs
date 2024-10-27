using System.Reflection.PortableExecutable;

public class Content{
    List<string> _words;
    List<string> _changedWords;

    public Content(){
        List<string> testList = new List<string>
        {
            "this", "that", "went"
        };
        _words = new List<string>(testList);
        _changedWords = new List<string>(testList);

    }
    public Content(string words){
        string[] wordsArray = words.Split(' ');
        List<string> wordsList = new List<string>(wordsArray);
        _words = new List<string>(wordsList);
        _changedWords = new List<string>(wordsList);
    }
    public List<string> getChangedWords(){
        return _changedWords;
    }
    public void displayWords(){
        foreach (string word in _changedWords)
        {Console.Write($"{word} ");}
    }
    public void resetWords(){
        _changedWords = new List<string>(_words);
    }
    public void changeWord(int index){
        string newString = "";
        foreach(char x in _changedWords[index]){
            newString += "_";
        }
        _changedWords[index] = newString;
    }
}