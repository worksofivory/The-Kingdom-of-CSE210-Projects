using System.IO;
public class Scripture{
    Reference _ref;
    Content _verse;

    public Scripture(){
        _ref = new Reference();
        _verse = new Content();
    }
    public Scripture(Reference reference, Content verse){
        _ref = reference;
        _verse = verse;
    }
    public void displayScripture(){
        _ref.displayReference();
        _verse.displayWords();
        System.Console.WriteLine();
    }
    public void removeWord(){
        Random randomGenerator = new Random();
        int _verseLength = _verse.getChangedWords().Count;
        bool changed = false;
        bool allChanged = true;
        foreach(string word in _verse.getChangedWords()){
            if(!word.Contains("_")){
                allChanged = false;
            }
        }
        if(!allChanged)
        {while(!changed){
            int spot = randomGenerator.Next(0, _verseLength);
            if(!_verse.getChangedWords()[spot].Contains("_")){
                _verse.changeWord(spot);
                changed=true;
            }
            }}
        displayScripture();
    }
    public void resetScripture(){
        _verse.resetWords();
    }
}