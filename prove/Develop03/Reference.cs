public class Reference{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(){
        _book = "Placeholder";
        _chapter = 1;
        _startVerse = 1;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string getBook(){
        return _book;
    }
    public int getChapter(){
        return _chapter;
    }
    public int getStartVerse(){
        return _startVerse;
    }
    public int getEndVerse(){
        return _endVerse;
    }
    public void displayReference(){
        if(_endVerse == 0){System.Console.WriteLine($"{_book} {_chapter}: {_startVerse}");}
        else{System.Console.WriteLine($"{_book} {_chapter}: {_startVerse}-{_endVerse}");}
    }
}