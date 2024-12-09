public abstract class Creature{
    protected int _maxHP;
    protected int _currentHP;
    protected int _armor;
    protected int _armorClass;
    protected int _goldHeld;
    protected Weapon _weapon;
    protected Inventory _inventory;
    public Creature(int hp, int armor, int gold, int armorClass, Weapon weapon){
        _maxHP = hp;
        _currentHP = hp;
        _armor = armor;
        _armorClass = armorClass;
        _goldHeld = gold;
        _weapon = weapon;
    }
    public void TakeDamage(int dmg){
        _currentHP -= dmg;
    }
    public int GetArmorClass(){
        return _armorClass;
    }
    public int GetMaxHealth(){
        return _maxHP;
    }
    public int GetCurrentHealth(){
        return _currentHP;
    }
    public void UpdateInventory(Inventory inv){
        _inventory = inv;
    }
    public Inventory GetCreatureInventory(){
        return _inventory;
    }
    public int GetGold(){
        return _goldHeld;
    }
    public Weapon GetWeapon(){
        return _weapon;
    }
    public virtual int ChangeDamage(int damage, Weapon weapon){
        int changedDamage = damage;
        return changedDamage;
    }
    public virtual int RemoveGold(int amount){
        _goldHeld -= amount;
        return _goldHeld;
    }
    public virtual void DisplayCreatureInfo(){

    }
}