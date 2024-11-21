public class SimpleGoal:Goal{

    public SimpleGoal(): base(){}
    public override void completeGoal(){
        _done = true;
    }
    public override void displayGoal(){
        System.Console.Write($"(Name:{_name} Desc:{_desc}\nPoints: {_pointValue}");
        if(_done){
            System.Console.WriteLine("[X])");
        }else{
            System.Console.WriteLine("[ ])");
        }
    }
}