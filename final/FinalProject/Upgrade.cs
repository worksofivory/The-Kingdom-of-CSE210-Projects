public class Upgrade:Item{
    public Upgrade(string name, string target, int buffValue, int goldValue):base(name, target, buffValue, goldValue){}
    public override int ApplyBuff(string target)
    {
        return _buffValue;
    }
    public override void DisplayDetails()
    {
        
    }
}