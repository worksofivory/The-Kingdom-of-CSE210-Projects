public class Player:Creature{
    string _name;
    string _race;
    int _numberOfTurnActions;
    int _innateBuff;

    public Player(int hp, int armor, int gold, int armorClass, Weapon weapon, string name, string race, int turnActions, int buff):base(hp, armor, gold, armorClass, weapon){
        _name = name;
        _race = race;
        _armorClass = armorClass;
        _numberOfTurnActions = turnActions;
        _innateBuff = buff;
    }
    public void AddPlayerPotion(Potion potion){
        _inventory.AddPotion(potion);
    }
    public void AddPlayerUpgrade(Upgrade upgrade){
        _inventory.AddUpgrade(upgrade);
    }
    public void SetPlayerName(string name){
        _name = name;
    }
    public int GetPlayerBuff(){
        return _innateBuff;
    }
    public void AddGold(int amount){
        _goldHeld += amount;
    }
    public override int ChangeDamage(int damage, Weapon weapon){
        int totalDamage = damage - _armor;
        return totalDamage;
    }
    public override void DisplayCreatureInfo()
    {
        System.Console.WriteLine($"You are {_name}, a {_race} wielding a {_weapon.GetModifier()} {_weapon.GetWeaponName()}\nYou have {_maxHP}/{_currentHP} health with {_armor} armor.");
    }
    public override int RemoveGold(int amount)
    {
        return base.RemoveGold(amount);
    }
}