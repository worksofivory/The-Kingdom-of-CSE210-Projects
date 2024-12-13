public abstract class Item{
    protected string _itemName;
    protected string _buffTarget;
    protected int _buffValue;
    protected int _goldValue;
    protected bool _activated = false;

    public Item(string name, string target, int buffValue, int goldValue){
        _itemName = name;
        _buffTarget = target;
        _buffValue = buffValue;
        _goldValue = goldValue;
    }
    public string GetItemName(){
        return _itemName;
    }
    public int GetGoldValue(){
        return _goldValue;
    }
    public void ActivateEffect(){
        _activated = true;
    }
    public bool GetActive(){
        return _activated;
    }
    public string GetTarget(){
        return _buffTarget;
    }
    public virtual int ApplyBuff(){
        return _buffValue;
    }
    public virtual void DisplayDetails(){

    }
}