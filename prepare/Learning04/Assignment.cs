public class Assignment{
    private string _studentName;
    private string _topic;

    public Assignment(){
        _studentName = "John Doe";
        _topic = "N/A";
    }
    public Assignment(string name, string topic){
        _studentName = name;
        _topic = topic;
    }
    public string getSummary(){
        return $"{_studentName} - {_topic}";
    }
    public string getStudentName(){
        return _studentName;
    }
}