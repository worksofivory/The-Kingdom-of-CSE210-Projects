public class Enemy:Creature{
    string _enemyType;
    string _damageResistance;
    string _damageWeakness;
    bool _isBoss;
    public Enemy(int hp, int armor, int gold, Weapon weapon, string type, string resist, string weak, bool boss, Potion potion, Upgrade upgrade):base(hp, armor, gold, weapon){
        _enemyType = type;
        _damageResistance = resist;
        _damageWeakness = weak;
        _isBoss = boss;
        _inventory.AddPotion(potion);
        _inventory.AddUpgrade(upgrade);
    }
    public Potion DropPotion(string potionName){
        return base.GetCreatureInventory().GetInventoryPotion(potionName);
    }
    public Upgrade DropUpgrade(string upgradeName){
        return base.GetCreatureInventory().GetInventoryUpgrade(upgradeName);
    }
    public void HandleDeath(){

    }
    public override int ChangeDamage(int damage)
    {
        return base.ChangeDamage(damage);
    }
    public override void RemoveGold(int amount)
    {
        base.RemoveGold(amount);
    }
    public override void DisplayCreatureInfo()
    {
        
    }
}