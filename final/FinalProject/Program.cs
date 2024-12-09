using System;

class Program
{
    static void Main(string[] args)
    {
        List<Weapon> weapons = new List<Weapon>{
            new Weapon("Club", "Bludgeoning", 4, 3),
            new Weapon("Greatsword", "Slashing", 8, 1),
            new Weapon("Spear", "Piercing", 6, 2),
            new Weapon("Battleaxe", "Slashing", 6, 2),
            new Weapon("Mace", "Bludgeoning", 4, 3)
        };
        List<Player> players = new List<Player>{
            new Player(100, 10, 10, 15, new Weapon("Greatsword", "Slashing", 8, 0), "BLANK", "Dragonborn", 2, 3),
            new Player(90, 6, 15, 12, new Weapon("Mace", "Bludgeoning", 4, 3), "BLANK", "Human", 4, 1),
            new Player(80, 5, 20, 18, new Weapon("Spear", "Piercing", 6, 2), "BLANK", "Elf", 4, 1),
            new Player(110, 8, 5, 16, new Weapon("Battleaxe", "Slashing", 6, 2), "BLANK", "Dwarf", 3, 2)
        };
        List<Enemy> enemies = new List<Enemy>{
            new Enemy(20, 5, 10, 12, null, "Goblin", "Piercing", "Bludgeoning", false, null, null),
            new Enemy(30, 2, 5, 10, null, "Slime", "Bludgeoning", "Slashing", false, null, null),
            new Enemy(15, 3, 15, 13, null, "Skeleton", "Slashing", "Bludgeoning", false, null, null),
            new Enemy(25, 4, 20, 14, null, "Ghoul", "Bludgeoning", "Piercing", false, null, null)
        };
        List<Potion> basicPotions = new List<Potion>{
            new Potion("Basic Healing Potion", "Health", 10, 5, 0), 
            new Potion("Basic Defense Potion", "Armor", 5, 8, 3),
            new Potion("Basic Attack Potion", "InnateBuff", 5, 8, 3)  
        };
        List<Potion> strongPotions = new List<Potion>{
            new Potion("Strong Healing Potion", "Health", 20, 10, 0),
            new Potion("Strong Defense Potion", "Armor", 10, 16, 2),
            new Potion("Strong Attack Potion", "InnateBuff", 10, 16, 2)
        };
        List<Upgrade> basicUpgrades = new List<Upgrade>{
            new Upgrade("Minor Health Ruby", "MaxHP", 10, 15),
            new Upgrade("Basic Armor Class Upgrade", "ArmorClass", 1, 20),
            new Upgrade("Basic Armor Improvement", "Armor", 5, 10),
            new Upgrade("Minor Attack Bracer", "InnateBuff", 3, 10)
        };
        List<Upgrade> powerfulUpgrades = new List<Upgrade>{
            new Upgrade("Major Health Ruby", "MaxHP", 20, 30),
            new Upgrade("Advanced Armor Class Upgrade", "ArmorClass", 2, 40),
            new Upgrade("Advanced Armor Improvement", "Armor", 10, 20),
            new Upgrade("Major Attack Gauntlet", "InnateBuff", 6, 20)
        };
        List<string> combatChoices = new List<string>{
            "1. Attack",
            "2. Block",
            "3. Access Inventory",
            "4. Flee"
        };
        List<string> shopChoices = new List<string>{
            "1. Purchase",
            "2. Sell",
            "3. Leave"
        };
        Inventory shopInventory1 = new Inventory();
        foreach(Potion potion in basicPotions){
            shopInventory1.AddPotion(potion);
        }
        foreach(Upgrade upgrade in basicUpgrades){
            shopInventory1.AddUpgrade(upgrade);
        }
        Inventory shopInventory2 = new Inventory();
        foreach(Potion potion in strongPotions){
            shopInventory2.AddPotion(potion);
        }
        foreach(Upgrade upgrade in powerfulUpgrades){
            shopInventory2.AddUpgrade(upgrade);
        }
        Shop shop1 = new Shop(shopInventory1, 300);
        Shop shop2 = new Shop(shopInventory2, 400);
        Enemy finalBoss = new Enemy(50, 0, 100, 18, new Weapon("The Lich's Blade", "Slashing", 14, 4), "The Lich", "bludgeoning", "slashing", true, null, null);
        bool isPlayerTurn = true;
        bool isEnemyTurn = false;
        int firstRoomCount = 0;
        int secondRoomCount = 0;

    }
}