public class Player:Creature{
    string _name;
    string _race;
    int _numberOfTurnActions;

    public Player(int hp, int armor, int gold, Weapon weapon, string name, string race, int turnActions):base(hp, armor, gold, weapon){
        _name = name;
        _race = race;
        _numberOfTurnActions = turnActions;
    }
    public void AddPlayerPotion(Potion potion){

    }
    public void AddPlayerUpgrade(Upgrade upgrade){

    }
    public void AddGold(int amount){
        _goldHeld += amount;
    }
    public override int ChangeDamage(int damage)
    {
        return base.ChangeDamage(damage);
    }
    public override void DisplayCreatureInfo()
    {
        base.DisplayCreatureInfo();
    }
    public override void RemoveGold(int amount)
    {
        base.RemoveGold(amount);
    }
}