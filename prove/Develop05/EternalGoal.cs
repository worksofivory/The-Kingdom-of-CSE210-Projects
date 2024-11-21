public class EternalGoal:Goal{
    int _timesCompleted = 0;
    public EternalGoal(): base(){}
    public int getTimesCompleted(){
        return _timesCompleted;
    }
    public void setCompleted(int timesCompleted){
        _timesCompleted = timesCompleted;
    }
    public override void completeGoal(){
        _done = false;
        _timesCompleted += 1;
    }
    public override void displayGoal()
    {
        System.Console.WriteLine($"(Name:{_name} Desc:{_desc}\n Points: {_pointValue}");
        System.Console.Write($"You've completed this goal {_timesCompleted} time(s)! ");
            System.Console.WriteLine("[ ])");
        
    }
}