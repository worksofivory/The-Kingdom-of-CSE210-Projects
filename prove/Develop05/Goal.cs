public abstract class Goal{
    protected bool _done = false;
    protected string _name;
    protected string _desc;
    protected int _pointValue;

    public void setDone(bool done){
        _done = done;
    }
    public void setName(string name){
        _name = name;
    }
    public void setDescription(string desc){
        _desc = desc;
    }
    public void setPoints(int points){
        _pointValue = points;
    }
    public bool getDone(){
        return _done;
    }
    public string getName(){
        return _name;
    }
    public string getDesc(){
        return _desc;
    }
    public int getPoints(){
        return _pointValue;
    }
    public virtual void constructGoal(bool done, string name, string desc, int points, int completions, int timesToComplete, int bonus){
        setDone(done);
        setName(name);
        setDescription(desc);
        setPoints(points);
    }
    public abstract void completeGoal();
    public abstract void displayGoal();
}