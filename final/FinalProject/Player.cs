public class Player:Creature{
    int _buffedMaxHP;
    string _name;
    string _race;
    int _numberOfTurnActions;
    int _innateBuff;
    int _currentBuff;
    int _currentArmor;

    public Player(int hp, int armor, int gold, int armorClass, Weapon weapon, string name, string race, int turnActions, int buff):base(hp, armor, gold, armorClass, weapon){
        _name = name;
        _race = race;
        _armorClass = armorClass;
        _armor = armor;
        _numberOfTurnActions = turnActions;
        _innateBuff = buff;
        _currentBuff = buff;
        _buffedMaxHP = hp;
        _currentArmor = armor;
    }
    public void ResetBuffs(){
        _currentArmor = _armor;
        _currentBuff = _innateBuff;
        _buffedMaxHP = _maxHP;
    }
    public void AddPotionBuff(Potion potion){
        potion.CheckEffectDuration();
        string target = potion.GetTarget().ToLower();
        bool isActive = potion.GetActive();
        bool isSpent = potion.CheckUsed();
        int buff = potion.ApplyBuff();
        if(isActive && !isSpent)
            {if(target == "health"){
                if(_currentHP >= _buffedMaxHP){
                    _currentHP += 0;
                }else{
                    System.Console.WriteLine($"You heal {buff} HP!");
                    System.Console.WriteLine("(HIT ENTER TO CONTINUE)");
                    System.Console.ReadLine();
                    _currentHP += buff;
                }
            }
            if(target == "armor"){
                System.Console.WriteLine($"You add {buff} Armor Points for {potion.GetDuration()} turns!");
                System.Console.WriteLine("(HIT ENTER TO CONTINUE)");
                System.Console.ReadLine();
                _currentArmor += buff;
            }
            if(target == "innatebuff"){
                System.Console.WriteLine($"You add +{buff} attack for {potion.GetDuration()} turns! (Raises chance to hit)");
                System.Console.WriteLine("(HIT ENTER TO CONTINUE)");
                System.Console.ReadLine();
                _currentBuff += buff;
            }}
    }
    public void AddUpgradeBuff(Upgrade upgrade){
        string target = upgrade.GetTarget().ToLower();
        int buff = upgrade.ApplyBuff();
        if(target == "health"){
                _buffedMaxHP += buff;
            }
            if(target == "armor"){
                _currentArmor += buff;
            }
            if(target == "innatebuff"){
                _currentBuff += buff;
            }
    }
    public void AddPlayerPotion(Potion potion){
        _inventory.AddPotion(potion);
    }
    public int GetTurnActions(){
        return _numberOfTurnActions;
    }
    public void AddPlayerUpgrade(Upgrade upgrade){
        _inventory.AddUpgrade(upgrade);
    }
    public void SetPlayerName(string name){
        string capitalized = name.Substring(0, 1).ToUpper() + name.Substring(1);
        _name = capitalized;
    }
    public int GetPlayerBuff(){
        return _currentBuff;
    }
    public string GetPlayerRace(){
        return _race;
    }
    public string GetPlayerName(){
        return _name;
    }
    public void AddGold(int amount){
        _goldHeld += amount;
    }
    public void DisplayPlayerHP(){
        System.Console.WriteLine($"{_currentHP}/{_buffedMaxHP}");
    }
    public void DisplayBaseInfo(){
        System.Console.WriteLine($"A {_race}, wielding a +{_weapon.GetModifier()} {_weapon.GetWeaponName()}");
        System.Console.WriteLine($">{_numberOfTurnActions} turn actions, with {_maxHP} Max HP, an Armor Class of {_armorClass}, and {_armor} armor.");
    }
    public override int ChangeDamage(int damage, Weapon weapon){
        int totalDamage = damage - _armor;
        if (totalDamage < 0){
            totalDamage = 0;
        }
        return totalDamage;
    }
    public override void DisplayCreatureInfo()
    {
        System.Console.WriteLine($"You are {_name}, a {_race} wielding a +{_weapon.GetModifier()} {_weapon.GetWeaponName()}\nYou have {_currentHP}/{_maxHP} health with {_armor} armor.");
    }
    public override int RemoveGold(int amount)
    {
        return base.RemoveGold(amount);
    }
}