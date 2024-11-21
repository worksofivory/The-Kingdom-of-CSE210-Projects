public class ChecklistGoal:Goal{
    int _completions;
    int _timesToComplete;
    int _bonusPoints;
    public ChecklistGoal(): base(){}
    public int getBonusPoints(){
       return _bonusPoints;
    }
    public int getCompletions(){
        return _completions;
    }
    public int getTimesToComplete(){
        return _timesToComplete;
    }
    public void setComplete(int completion){
        _timesToComplete = completion;
    }
    public void setBonus(int bonus){
        _bonusPoints = bonus;
    }
    public void smallCompletion(){
        _completions +=1;
    }
    public void setCompletions(int completions){
        _completions = completions;
    }
    public override void constructGoal(bool done, string name, string desc, int points, int completions, int timesToComplete, int bonus){
        setDone(done);
        setName(name);
        setDescription(desc);
        setPoints(points);
        setCompletions(completions);
        setComplete(timesToComplete);
        setBonus(bonus);
    }
    public override void completeGoal(){
        if(_completions == _timesToComplete){
            _done = true;
        }
    }
    public override void displayGoal(){
        System.Console.Write($"(Name:{_name} Desc:{_desc}\nCompletions:{_completions}/{_timesToComplete} Points:{_pointValue}");
        if(_done){
            System.Console.WriteLine("[X]");
        }else{
            System.Console.WriteLine("[ ])");
        }
    }
}