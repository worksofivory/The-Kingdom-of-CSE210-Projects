public class Potion:Item{
    int _duration;
    int _currentUse = 0;
    bool _used;
    public Potion(string name, string target, int buffValue, int goldValue, int duration) :base(name, target, buffValue, goldValue){
        _duration = duration;
    }
    public void EndEffect(){
        if(_currentUse == _duration){
            _used = true;
        }
    }
    public override int ApplyBuff(string target)
    {
        return _buffValue;
    }
    public override void DisplayDetails()
    {
        
    }
}