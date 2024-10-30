public class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(){
        _textbookSection = "Section 0.0";
        _problems = "Problems 1-5";
    }
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic){
        _textbookSection = $"Section {section}";
        _problems = $"Problems {problems}";
    }
    public string getHomeworkList(){
        return $"{_textbookSection} {_problems}";
    }
}