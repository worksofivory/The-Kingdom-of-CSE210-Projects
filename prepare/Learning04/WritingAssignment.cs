public class WritingAssignment : Assignment{
    string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic){
        _title = title;
    }
    public string getWritingAssignment(){
        return $"{_title} by {base.getStudentName()}";
    }
}