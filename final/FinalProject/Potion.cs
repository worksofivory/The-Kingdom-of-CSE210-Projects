public class Potion:Item{
    int _duration;
    int _currentUse = 0;
    bool _used;
    public Potion(string name, string target, int buffValue, int goldValue, int duration) :base(name, target, buffValue, goldValue){
        _duration = duration;
    }
    public void CheckEffectDuration(){
        if(_currentUse == _duration){
            _used = true;
        }
    }
    public int GetDuration(){
        return _duration;
    }
    public void AddDuration(){
        _currentUse +=1;
    }
    public bool CheckUsed(){
        return _used;
    }
    public override int ApplyBuff()
    {
        if(_used){
            return 0;
        }else{
            return _buffValue;
        }
        
    }
    public override void DisplayDetails()
    {
        if(_buffTarget.ToLower() == "Health"){
            System.Console.WriteLine($"POTION\n{_itemName} Adds +{_buffValue} to {_buffTarget}\nValue:{_goldValue}");
        }else{
            System.Console.WriteLine($"POTION\n{_itemName} Adds +{_buffValue} to {_buffTarget} for {_duration} turn(s)\nValue:{_goldValue}");
        }
        
    }
}