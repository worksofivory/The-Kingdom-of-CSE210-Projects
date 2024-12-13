using System;

class Program
{
    static void Main(string[] args)
    {
        List<Potion> emptyPotions = new List<Potion>{
        };
        List<Upgrade> emptyUpgrades = new List<Upgrade>{
        };
        Inventory emptyInventory = new Inventory(emptyPotions, emptyUpgrades);
        List<Weapon> weapons = new List<Weapon>{
            new Weapon("Club", "Bludgeoning", 4, 3),
            new Weapon("Greatsword", "Slashing", 8, 1),
            new Weapon("Spear", "Piercing", 6, 2),
            new Weapon("Battleaxe", "Slashing", 6, 2),
            new Weapon("Mace", "Bludgeoning", 4, 3)
        };
        List<Player> players = new List<Player>{
            new Player(100, 4, 10, 15, new Weapon("Greatsword", "Slashing", 10, 1), "BLANK", "Dragonborn", 2, 3),
            new Player(90, 2, 15, 12, new Weapon("Mace", "Bludgeoning", 4, 3), "BLANK", "Human", 4, 1),
            new Player(80, 1, 20, 18, new Weapon("Spear", "Piercing", 6, 2), "BLANK", "Elf", 4, 1),
            new Player(110, 3, 5, 16, new Weapon("Battleaxe", "Slashing", 6, 2), "BLANK", "Dwarf", 3, 2)
        };
        List<Enemy> enemies = new List<Enemy>{
            new Enemy(20, 5, 10, 12, new Weapon("Hands", "Bludgeoning", 2, 1), "Goblin", "Piercing", "Bludgeoning", false),
            new Enemy(30, 2, 5, 10, new Weapon("Hands", "Bludgeoning", 2, 1), "Slime", "Bludgeoning", "Slashing", false),
            new Enemy(15, 3, 15, 13, new Weapon("Hands", "Bludgeoning", 2, 1), "Skeleton", "Slashing", "Bludgeoning", false),
            new Enemy(25, 4, 20, 14, new Weapon("Hands", "Bludgeoning", 2, 1), "Ghoul", "Bludgeoning", "Piercing", false)
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
        Inventory shopInventory1 = new Inventory(emptyPotions, emptyUpgrades);
        foreach(Potion potion in basicPotions){
            shopInventory1.AddPotion(potion);
        }
        foreach(Upgrade upgrade in basicUpgrades){
            shopInventory1.AddUpgrade(upgrade);
        }
        Inventory shopInventory2 = new Inventory(emptyPotions, emptyUpgrades);
        foreach(Potion potion in strongPotions){
            shopInventory2.AddPotion(potion);
        }
        foreach(Upgrade upgrade in powerfulUpgrades){
            shopInventory2.AddUpgrade(upgrade);
        }
        Player player1 = new Player(100, 10, 10, 15, new Weapon("Greatsword", "Slashing", 8, 0), "BLANK", "Dragonborn", 2, 3);
        Shop shop1 = new Shop(shopInventory1, 300);
        Shop shop2 = new Shop(shopInventory2, 400);
        Enemy finalBoss = new Enemy(50, 0, 100, 18, new Weapon("The Lich's Blade", "Slashing", 14, 4), "Lich Azog", "bludgeoning", "slashing", true);
        bool playerKilled = false;
        bool bossKilled = false;
        System.Console.WriteLine("!!Welcome to Assault on Azog!!!");
        System.Console.WriteLine("Now, let's figure out who you are, of these four adventurers, which best describes your character?");
        int counter = 0;
        int choosePlayer = 0;
        foreach(Player player in players){
            counter +=1;
            System.Console.Write($"{counter}. ");
            player.DisplayBaseInfo();
        }
        choosePlayer = int.Parse(Console.ReadLine());
        if(choosePlayer == 1){
            player1 = players[0];
        }
        if(choosePlayer == 2){
            player1 = players[1];
        }
        if(choosePlayer == 3){
            player1 = players[2];
        }
        if(choosePlayer == 4){
            player1 = players[3];
        }
        Console.Clear();
        System.Console.WriteLine($"That's right, a proud {player1.GetPlayerRace()}...");
        System.Console.WriteLine("What about your name?");
        player1.SetPlayerName(Console.ReadLine());
        System.Console.WriteLine($"Wonderful... you're ready to begin your journey, good luck {player1.GetPlayerName()}!");
        Console.Clear();
        System.Console.WriteLine("You are a travelling adventurer, you've heard of a small village, known by the name of Ruby Town, being accosted by a terrible Lich,\nhowever he hides in a high tower, heavily defended by deadly monsters.");
        System.Console.WriteLine("You stand before the tower, your weapon clutched tightly in your hand as you take a deep breath, and enter the first floor.");
        System.Console.WriteLine("(HIT ENTER TO CONTINUE)");
        Console.ReadLine();
        while(!playerKilled && !bossKilled){
            Console.Clear();
            playerKilled = HandleEncounter(enemies, weapons, basicPotions, basicUpgrades, player1);
            playerKilled = HandleEncounter(enemies, weapons, basicPotions, basicUpgrades, player1);
            playerKilled = HandleEncounter(enemies, weapons, basicPotions, basicUpgrades, player1);
            System.Console.WriteLine("You leave the first floor, exhausted from your fights.\nGrateful for your assistance, the villagers offer you a bed, and access to their first shop.  You decide to pay a visit before heading to bed for the night.");
            System.Console.WriteLine("(HIT ENTER TO CONTINUE)");
            System.Console.ReadLine();
            HandleShop(shop1, player1);
            System.Console.WriteLine("Your preparations made, you head to bed.");
            Thread.Sleep(1000);
            System.Console.Write(".");
            Thread.Sleep(1000);
            System.Console.Write(".");
            Thread.Sleep(1000);
            System.Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("As you wake, you find yourself still somewhat tired.  Your sleep was not as restful as you'd hoped, plagued by nightmares you assume planted by Azog.");
            Thread.Sleep(1000);
            System.Console.WriteLine("Nevertheless, you have a job to do, and you make your way to the second floor of the tower.");
            System.Console.WriteLine("(HIT ENTER TO CONTINUE)");
            System.Console.ReadLine();
            Console.Clear();
            playerKilled = HandleEncounter(enemies, weapons, strongPotions, powerfulUpgrades, player1);
            playerKilled = HandleEncounter(enemies, weapons, strongPotions, powerfulUpgrades, player1);
            playerKilled = HandleEncounter(enemies, weapons, strongPotions, powerfulUpgrades, player1);
            Console.Clear();
            System.Console.WriteLine("You're feeling confident as you leave the tower a second time.\nTomorrow you face the lich, the villagers are able to open a shop of more powerful items for you to prepare yourself.");
            System.Console.WriteLine("(HIT ENTER TO CONTINUE)");
            System.Console.ReadLine();
            HandleShop(shop2, player1);
            System.Console.WriteLine("You once again climb into bed, heart racing with anticipation as you know tomorrow is the day you fight the lich.");
            Thread.Sleep(1000);
            System.Console.Write(".");
            Thread.Sleep(1000);
            System.Console.Write(".");
            Thread.Sleep(1000);
            System.Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("Your sleep was more restful than the previous night.  You guess it's because Azog's influence is diminished with the slaying of his followers.");
            Thread.Sleep(1000);
            System.Console.WriteLine("As you stand before the doors to the lich's throne room, you feel a wave of apprehension wash over you.\nYou've never faced such a foe. But you steel yourself, kicking the doors wide open and initiating your battle.");
            System.Console.WriteLine("(HIT ENTER TO CONTINUE)");
            System.Console.ReadLine();
            playerKilled = HandleFinalEncounter(finalBoss, player1);
            bossKilled = true;
        }
        if(playerKilled){
            Thread.Sleep(1000);
            System.Console.Write("You");
            Thread.Sleep(1000);
            System.Console.Write("Are");
            Thread.Sleep(1000);
            System.Console.WriteLine("Dead...");
            Thread.Sleep(1000);
            Console.Clear();
        }
        if(bossKilled){
            System.Console.WriteLine("You let out a shout of defiance as you cut down your foe. You feel a rush of heat as Azog's body crumbles to dust before you.");
            Thread.Sleep(1000);
            System.Console.WriteLine("You feel the tower begin to rumble beneath your feet, you scoop up the Lich's enchanted blade and flee.");
            Thread.Sleep(1000);
            System.Console.Write(".");
            Thread.Sleep(1000);
            System.Console.Write(".");
            Thread.Sleep(1000);
            System.Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("You barely manage to escape the tower as it collapses, now devoid of the lich's power.");
            Thread.Sleep(1000);
            System.Console.WriteLine("You partake in a glorious feast with the villagers to celebrate your victory.  They ask you to stay, but you insist that you have others to defend as you leave a hero.  You smile, satisfied with the service you were able to offer.");
            Console.Clear();
            System.Console.WriteLine("YOU WON!!\nThank you for playing! :)");
        }
    }
    private static void HandlePlayerAttack(Player player, Enemy enemy){
        Console.Clear();
        System.Console.WriteLine("***You attack the enemy!");
        Random randomGenerator = new Random();
        int dice = randomGenerator.Next(0, 20);
        Weapon playerWeapon = player.GetWeapon();
        int weaponDamage = playerWeapon.GetDamage();
        string damageType = playerWeapon.GetDamageType();
        int totalRoll = dice+playerWeapon.GetModifier()+player.GetPlayerBuff();
        int damageTaken = enemy.ChangeDamage(weaponDamage, playerWeapon);
        if(totalRoll >= enemy.GetArmorClass()){
            System.Console.WriteLine($"***You successfully land a blow on [{enemy.GetType()}]!");
            enemy.TakeDamage(damageTaken);
            System.Console.WriteLine($">The [{enemy.GetEnemyType()}] takes {damageTaken} damage!");
            Thread.Sleep(1000);
        }
        else if(dice == 20){
            System.Console.WriteLine("!!!CRITICAL HIT!!!");
            enemy.TakeDamage(damageTaken*2);
            System.Console.WriteLine($">The [{enemy.GetEnemyType()}] takes {damageTaken*2} damage!!!");
            Thread.Sleep(1000);
        }
        else{
            System.Console.WriteLine("***The enemy swiftly dodges...");
            Thread.Sleep(1000);
        }
    }
    private static void HandleEnemyAttack(Player player, Enemy enemy, bool blocked){
        Console.Clear();
        System.Console.WriteLine("***The enemy swings!");
        Random randomGenerator = new Random();
        int dice = randomGenerator.Next(0, 20);
        Weapon enemyWeapon = enemy.GetWeapon();
        int weaponDamage = enemyWeapon.GetDamage();
        string damageType = enemyWeapon.GetDamageType();
        int totalRoll = dice+enemyWeapon.GetModifier();
        int damageTaken = player.ChangeDamage(weaponDamage, enemyWeapon);
        if(blocked){
            System.Console.WriteLine("You take half damage because you blocked on your turn!");
            Thread.Sleep(1000);
            damageTaken = damageTaken/2;
        }
        if(totalRoll >= enemy.GetArmorClass()){
            System.Console.WriteLine($"***You fail to avoid the attack...");
            Thread.Sleep(1000);
            player.TakeDamage(damageTaken);
            System.Console.WriteLine($">You take {damageTaken} damage!");
            Thread.Sleep(1000);
        }
        else if(dice == 20){
            System.Console.WriteLine("!!!CRITICAL HIT!!!");
            Thread.Sleep(1000);
            player.TakeDamage(damageTaken*2);
            System.Console.WriteLine($">You take {damageTaken*2} damage!!!");
            Thread.Sleep(1000);
        }
        else{
            System.Console.WriteLine("***The enemy fails to hit you!");
            Thread.Sleep(1000);
        }
    }
    private static void HandleInventory(Inventory inventory){
        Console.Clear();
        List<string> inventoryChoices = new List<string>{
            "1. Access Potions",
            "2. View Upgrades",
            "3. Exit Inventory"
        };
        int menuInput = 0;
        foreach(string item in inventoryChoices){
            System.Console.WriteLine($"{item}");
        }
        while(menuInput != 3)
            {System.Console.WriteLine("What would you like to do?");
            menuInput = int.Parse(System.Console.ReadLine());
            if(menuInput == 1){
                inventory.ListInventoryPotions();
                System.Console.WriteLine("Type the name of the potion you want to use. (TYPE \"back\" IF YOU CHANGED YOUR MIND)");
                string chosenPotion = System.Console.ReadLine();
                if(chosenPotion.ToLower() == "back"){
                    menuInput = 0;
                }else{
                   inventory.GetInventoryPotion(chosenPotion).ActivateEffect(); 
                }
                menuInput = 0;
            }
            if(menuInput == 2){
                inventory.ListInventoryUpgrades();
                menuInput = 0;
            }}
    }
    private static bool PlayerTurn(Player player, Enemy enemy){
        int turnActions = player.GetTurnActions();
        bool blocked = false;
        player.ResetBuffs();
        Inventory playerInventory = player.GetCreatureInventory();
        ApplyBuffs(player);
        List<string> combatChoices = new List<string>{
            "1. Attack",
            "2. Block (Can only be done once per turn)",
            "3. Access Inventory",
            "4. Check Stats"
        };
        int menuInput = 0;
        System.Console.WriteLine("***It's your turn!");
        while(turnActions > 0){
           Console.Clear();
           System.Console.WriteLine($"You have {turnActions} action(s) left");
           foreach(string item in combatChoices){
            System.Console.WriteLine($"{item}");
           }
           System.Console.WriteLine("What would you like to do?");
           string stringMenuInput = System.Console.ReadLine();
           try
            {
                menuInput = int.Parse(stringMenuInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a valid input, try one of the offered options.");
            }
           if(menuInput == 1){
            HandlePlayerAttack(player, enemy);
            turnActions -=1;
            menuInput = 0;
           }
           if(menuInput == 2 && !blocked){
            blocked = true;
            turnActions -=1;
            menuInput = 0;
           }
           if(menuInput ==2 && blocked){
            System.Console.WriteLine("You already blocked this turn!  Try something else.");
            menuInput = 0;
           }
           if(menuInput == 3){
            HandleInventory(playerInventory);
            menuInput = 0;
           }
           if(menuInput == 4){
            player.DisplayCreatureInfo();
            System.Console.WriteLine("(HIT ENTER TO GO BACK)");
            Console.ReadLine();
            menuInput = 0;
           }
           if(menuInput > 4 || menuInput < 1 && turnActions > 0){
            System.Console.WriteLine("Not a valid input, try again");
            menuInput = 0;
           }
        }
        return blocked;
    }
    private static void ApplyBuffs(Player player){
        Inventory inventory = player.GetCreatureInventory();
        List<Potion> potions = inventory.GetPotions();
        List<Upgrade> upgrades = inventory.GetUpgrades();
        foreach(Potion potion in potions){
            player.AddPotionBuff(potion);
            potion.AddDuration();
        }
        foreach(Upgrade upgrade in upgrades){
            player.AddUpgradeBuff(upgrade);
        }
    }
    private static bool HandleEncounter(List<Enemy> enemies, List<Weapon> weapons, List<Potion> potions, List<Upgrade> upgrades, Player player){
        Random random = new Random();
        int enemyListLength = enemies.Count();
        int weaponListLength = weapons.Count();
        int potionListLength = potions.Count();
        int upgradeListLength = upgrades.Count();
        bool enemyKilled = false;
        bool playerKilled = false;
        int pickedEnemy = random.Next(0, enemyListLength);
        int pickedWeapon = random.Next(0, weaponListLength);
        int pickedPotion = random.Next(0, potionListLength);
        int pickedUpgrade = random.Next(0, upgradeListLength);
        int dropUpgradeCheck = random.Next(0, 20);
        bool blocked = false;
        Enemy enemy = new Enemy(enemies[pickedEnemy]);
        enemy.SetWeapon(weapons[pickedWeapon]);
        enemy.SetInventory(potions[pickedPotion], upgrades[pickedUpgrade]);
        Console.Clear();
        System.Console.WriteLine($"You encounter a(n) {enemy.GetEnemyType()} wielding a(n) {enemy.GetWeapon().GetWeaponName()}! (ENTER TO CONTINUE)");
        Console.ReadLine();
        while(!enemyKilled && !playerKilled){
            Console.Clear();
            System.Console.Write("Current Health: ");
            player.DisplayPlayerHP();
            System.Console.WriteLine($"Enemy Health: {enemy.GetCurrentHealth()}/{enemy.GetMaxHealth()}");
            System.Console.Write("Wait");
            Thread.Sleep(200);
            System.Console.Write(".");
            Thread.Sleep(200);
            System.Console.Write(".");
            Thread.Sleep(200);
            System.Console.WriteLine(".");
            Thread.Sleep(200);
            if(player.GetCurrentHealth() <= 0){
                playerKilled = true;
                return playerKilled;
            }
            blocked = PlayerTurn(player, enemy);
            if(enemy.GetCurrentHealth() <= 0){
                if(dropUpgradeCheck == 20){
                    System.Console.WriteLine($"!!!The enemy dropped an upgrade ({upgrades[pickedUpgrade].GetItemName()})!!!");
                    player.AddPlayerUpgrade(enemy.DropUpgrade());
                }else{
                    System.Console.WriteLine($"The enemy drops their potion! ({potions[pickedPotion].GetItemName()})");
                    player.AddPlayerPotion(enemy.DropPotion());
                }
                System.Console.WriteLine("You collect some gold from the fallen foe.");
                Thread.Sleep(500);
                System.Console.WriteLine($"{enemy.GetGold()} gold added to your inventory!");
                System.Console.WriteLine("(HIT ENTER TO CONTINUE)");
                Console.ReadLine();
                player.AddGold(enemy.RemoveGold(enemy.GetGold()));
                enemyKilled = true;
            }
            if(!enemyKilled){
                HandleEnemyAttack(player, enemy, blocked);
            } 
        }
        if(playerKilled){
            return true;
        }else{
            return false;
        }
    }
    private static bool HandleFinalEncounter(Enemy enemy, Player player){
        Console.Clear();
        Random random = new Random();
        bool playerKilled = false;
        bool enemyKilled = false;
        bool blocked = false;
        System.Console.WriteLine($"You stand before the Lich, Azog!  You can feel the power of his magic in the air as he draws his shimmering blade, this is going to be a tough fight!");
        Thread.Sleep(200);
        System.Console.Write(".");
        Thread.Sleep(200);
        System.Console.Write(".");
        Thread.Sleep(200);
        System.Console.WriteLine(".");
        Thread.Sleep(200);
        Console.Clear();
        while(!enemyKilled && !playerKilled){
            Console.Clear();
            int whichAttack = random.Next(1,3);
            System.Console.Write("Current Health: ");
            player.DisplayPlayerHP();
            System.Console.WriteLine($"Enemy Health: {enemy.GetCurrentHealth()}/{enemy.GetMaxHealth()}");
            if(player.GetCurrentHealth() <= 0){
                playerKilled = true;
                return playerKilled;
            }
            blocked = PlayerTurn(player, enemy);
            if(enemy.GetCurrentHealth() <= 0){
                enemyKilled = true;
            }
            if(!enemyKilled)
                {if(whichAttack == 1){
                    System.Console.WriteLine("The Lich's blade surges with power as he swings at you!");
                    HandleEnemyAttack(player, enemy, blocked);
                }
                if(whichAttack == 2){
                    System.Console.WriteLine("The Lich sends a crackling surge of energy at you!");
                    HandleEnemyAttack(player, enemy, blocked);
                }
                if(whichAttack == 3){
                    System.Console.WriteLine("Your heart fills with dread as the room goes dark...");
                    HandleEnemyAttack(player, enemy, blocked);
                }}
        }
        if(playerKilled){
            return true;
        }else{
            return false;
        }
    }
    private static void HandleShop(Shop shop, Player player){
        List<string> shopChoices = new List<string>{
            "1. Purchase",
            "2. Sell",
            "3. Leave"
        };
        List<string> buyChoices = new List<string>{
            "1. Purchase Potion",
            "2. Purchase Upgrade",
            "3. Go Back"
        };
        List<string> sellChoices = new List<string>{
            "1. Sell Potion",
            "2. Sell Upgrade",
            "3. Go Back"
        };
        int menuInput = 0;
        int buyInput = 0;
        int sellInput = 0;
        Console.Clear();
        Inventory shopInv = shop.GetShopInventory();
        System.Console.WriteLine("Welcome to the shop! Please take a look at my wares to help you on your journey!");
        while(menuInput != 3){
            foreach(string item in shopChoices){
            System.Console.WriteLine($"{item}");}
            System.Console.WriteLine("What would you like to do?");
            menuInput = int.Parse(System.Console.ReadLine());
            if(menuInput == 1){
                Console.Clear();
                shop.DisplayShop();
                while(buyInput!=3){
                    foreach(string item in buyChoices){
                    System.Console.WriteLine($"{item}");}
                    buyInput = int.Parse(System.Console.ReadLine());
                    if(buyInput == 1){
                        System.Console.WriteLine("***SHOP INVENTORY");
                        shopInv.ListInventoryPotions();
                        System.Console.WriteLine("***PLAYER INVENTORY");
                        player.GetCreatureInventory().ListInventoryPotions();
                        System.Console.WriteLine("Type the name of the upgrade you want to buy.\n***PLEASE NOTE YOU CANNOT BUY DUPLLICATES OF WHAT YOU ALREADY HAVE, YOU WILL LOSE YOUR GOLD AND GAIN NOTHING.");
                        string chosenPotion = System.Console.ReadLine();
                        player.AddPlayerPotion(shop.SellPotion(chosenPotion, player.GetGold()));
                        buyInput = 0;
                    }
                    if(buyInput == 2){
                        System.Console.WriteLine("***SHOP INVENTORY");
                        shopInv.ListInventoryUpgrades();
                        System.Console.WriteLine("***PLAYER INVENTORY");
                        player.GetCreatureInventory().ListInventoryUpgrades();
                        System.Console.WriteLine("Type the name of the upgrade you want to buy.\n***PLEASE NOTE YOU CANNOT BUY DUPLLICATES OF WHAT YOU ALREADY HAVE, YOU WILL LOSE YOUR GOLD AND GAIN NOTHING.");
                        string chosenUpgrade = System.Console.ReadLine();
                        player.AddPlayerUpgrade(shop.SellUpgrade(chosenUpgrade, player.GetGold()));
                        buyInput = 0;
                    }
                }
            }
            if(menuInput == 2){
                Console.Clear();
                shop.DisplayShop();
                while(sellInput!=3){
                    foreach(string item in sellChoices){
                    System.Console.WriteLine($"{item}");}
                    buyInput = int.Parse(System.Console.ReadLine());
                    if(sellInput ==1){
                        System.Console.WriteLine("***SHOP INVENTORY");
                        shopInv.ListInventoryPotions();
                        System.Console.WriteLine("***PLAYER INVENTORY");
                        player.GetCreatureInventory().ListInventoryPotions();
                        System.Console.WriteLine("Type the name of the potion you want to sell.");
                        string chosenPotion = System.Console.ReadLine();
                        player.AddGold(shop.BuyPotion(player.GetCreatureInventory().RemoveInventoryPotion(chosenPotion)));
                        buyInput = 0;
                    }
                    if(sellInput ==2){
                        System.Console.WriteLine("***SHOP INVENTORY");
                        shopInv.ListInventoryUpgrades();
                        System.Console.WriteLine("***PLAYER INVENTORY");
                        player.GetCreatureInventory().ListInventoryUpgrades();
                        System.Console.WriteLine("Type the name of the upgrade you want to sell.");
                        string chosenUpgrade = System.Console.ReadLine();
                        player.AddGold(shop.BuyUpgrade(player.GetCreatureInventory().RemoveInventoryUpgrade(chosenUpgrade)));
                        buyInput = 0;
                    }
                    }
            }
            }
    }
}