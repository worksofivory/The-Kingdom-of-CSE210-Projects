public class Upgrade:Item{
    public Upgrade(string name, string target, int buffValue, int goldValue):base(name, target, buffValue, goldValue){
        _activated = true;
    }
    public override int ApplyBuff()
    {
        if(_activated){
            return _buffValue;
        }else{
            return 0;
        }    
    }
    public override void DisplayDetails()
    {
        System.Console.WriteLine($"UPGRADE\n{_itemName} Adds +{_buffValue} to {_buffTarget}\nValue:{_goldValue}");
    }
}