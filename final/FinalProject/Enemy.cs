public class Enemy:Creature{
    string _enemyType;
    string _damageResistance;
    string _damageWeakness;
    bool _isBoss;
    public Enemy(int hp, int armor, int gold, int armorClass, Weapon weapon, string type, string resist, string weak, bool boss, Potion potion, Upgrade upgrade):base(hp, armor, gold, armorClass, weapon){
        _enemyType = type;
        _damageResistance = resist;
        _damageWeakness = weak;
        _isBoss = boss;
        _armorClass = armorClass;
        _inventory.AddPotion(potion);
        _inventory.AddUpgrade(upgrade);
    }
    public Potion DropPotion(string potionName){
        return base.GetCreatureInventory().GetInventoryPotion(potionName);
    }
    public Upgrade DropUpgrade(string upgradeName){
        return base.GetCreatureInventory().GetInventoryUpgrade(upgradeName);
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
        System.Console.WriteLine($"{_enemyType}\nHealth: {_maxHP}/{_currentHP}\nWeapon: {_weapon.GetWeaponName()}\nWeakness: {_damageWeakness}  Resistance: {_damageResistance}");
    }
}