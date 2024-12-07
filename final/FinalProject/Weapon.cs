public class Weapon{
    string _weaponName;
    string _damageType;
    int _weaponDamage;
    int _atkModifier;

    public Weapon(string name, string dmgType, int dmg, int mod){
        _weaponName = name;
        _damageType = dmgType;
        _weaponDamage = dmg;
        _atkModifier = mod;
    }
    public string GetDamageType(){
        return _damageType;
    }
    public int GetDamage(){
        return _weaponDamage;
    }
    public int GetModifier(){
        return _atkModifier;
    }
    public void DisplayWeapon(){
        System.Console.WriteLine($"Weapon: {_weaponName}\nDamage Type: {_damageType}\nWeapon Modifier: +{_atkModifier} Weapon Damage: {_weaponDamage}");
    }
}