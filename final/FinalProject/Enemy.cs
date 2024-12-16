public class Enemy:Creature{
    string _enemyType;
    string _damageResistance;
    string _damageWeakness;
    string _heldPotion;
    string _heldUpgrade;
    bool _isBoss;
    public Enemy(int hp, int armor, int gold, int armorClass, Weapon weapon, string type, string resist, string weak, bool boss):base(hp, armor, gold, armorClass, weapon){
        _enemyType = type;
        _damageResistance = resist;
        _damageWeakness = weak;
        _isBoss = boss;
        _armorClass = armorClass;
    }
    public Enemy(Enemy otherEnemy) : base(otherEnemy._maxHP, otherEnemy._armor, otherEnemy._goldHeld, otherEnemy._armorClass, otherEnemy._weapon) {
        _enemyType = otherEnemy._enemyType;
        _damageResistance = otherEnemy._damageResistance;
        _damageWeakness = otherEnemy._damageWeakness;
        _isBoss = otherEnemy._isBoss;
        _heldPotion = otherEnemy._heldPotion;
        _heldUpgrade = otherEnemy._heldUpgrade;
    }
    public void SetWeapon(Weapon weapon){
        _weapon = weapon;
    }
    public string GetEnemyType(){
        return _enemyType;
    }
    public void SetInventory(Potion potion, Upgrade upgrade){
        if (_inventory == null) {
        _inventory = new Inventory(new List<Potion>(), new List<Upgrade>());
        }
        _inventory.AddPotion(potion);
        _heldPotion = potion.GetItemName();
        _inventory.AddUpgrade(upgrade);
        _heldUpgrade = upgrade.GetItemName();
    }
    public Potion DropPotion(){
        return base.GetCreatureInventory().GetInventoryPotion(_heldPotion);
    }
    public Upgrade DropUpgrade(){
        return base.GetCreatureInventory().GetInventoryUpgrade(_heldUpgrade);
    }
    public override int ChangeDamage(int damage, Weapon weapon){
        int newDamage = damage;
        if(weapon.GetDamageType().ToLower() == _damageResistance.ToLower()){
            newDamage = (int)(newDamage * 0.75);
        }
        if(weapon.GetDamageType().ToLower() == _damageWeakness.ToLower()){
            newDamage = (int)(newDamage * 1.75);
        }
        return newDamage;
    }
    public override int RemoveGold(int amount){
        return _goldHeld;
    }
    public override void DisplayCreatureInfo(){
        System.Console.WriteLine($"{_enemyType}\nHealth: {_currentHP}/{_maxHP}\nWeapon: {_weapon.GetWeaponName()}\nWeakness: {_damageWeakness}  Resistance: {_damageResistance}");
    }
}