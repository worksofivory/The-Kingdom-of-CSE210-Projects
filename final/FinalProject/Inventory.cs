public class Inventory{
     List<Potion> _potions;
     List<Upgrade> _upgrades;

     public Inventory(List<Potion> potions, List<Upgrade> upgrades){
      _potions = potions;
      _upgrades = upgrades;
     }
     public void AddPotion(Potion potion){
      if (potion == null){
        System.Console.WriteLine("Error: Cannot add a null potion.");
        return;
    }foreach(Potion listPotion in _potions){
         if(listPotion.GetItemName() == potion.GetItemName()){
            System.Console.WriteLine($"The pouch for the {potion.GetItemName()} is full, the item will not be added.");
            return;
         }
      }
         _potions.Add(potion);
      
     }
     public void AddUpgrade(Upgrade upgrade){
      if (upgrade == null){
        System.Console.WriteLine("Error: Cannot add a null upgrade.");
        return;
    }
      foreach(Upgrade listUpgrade in _upgrades){
         if(listUpgrade.GetItemName() == upgrade.GetItemName())
         {System.Console.WriteLine($"The pouch for the {upgrade.GetItemName()} is full, the item will not be added.");
            return;}
      }
         _upgrades.Add(upgrade);
     }
     public List<Potion> GetPotions(){
      return _potions;
     }
     public List<Upgrade> GetUpgrades(){
      return _upgrades;
     }
     public Potion GetInventoryPotion(string name){
        foreach(Potion potion in _potions){
            if(potion.GetItemName().ToLower()==name.ToLower()){
               return potion;
            }else{
               System.Console.WriteLine("That's not available...");
               return null;
            }
        }
        System.Console.WriteLine("That's not available...");
        return null;
     }
     public Potion RemoveInventoryPotion(string name){
        foreach(Potion potion in _potions){
            if(potion.GetItemName().ToLower()==name.ToLower()){
               _potions.Remove(potion);
               return potion;
            }
        }
        System.Console.WriteLine("That's not available...");
        return new Potion("Empty Pouch", "NONE", 0, 0, 0);
     }
     public Upgrade GetInventoryUpgrade(string name){
        foreach(Upgrade upgrade in _upgrades){
            if(upgrade.GetItemName().ToLower()==name.ToLower()){
               return upgrade;
            }
        }
        System.Console.WriteLine("That's not available...");
        return new Upgrade("Empty Pouch", "NONE", 0, 0);
     }
     public Upgrade RemoveInventoryUpgrade(string name){
        foreach(Upgrade upgrade in _upgrades){
            if(upgrade.GetItemName().ToLower()==name.ToLower()){
               _upgrades.Remove(upgrade);
               return upgrade;
            }else{
               System.Console.WriteLine("That's not available...");
               return null;
            }
        }
        System.Console.WriteLine("That's not available...");
        return null;
     }
     public void ListInventoryPotions(){
      System.Console.WriteLine("POTIONS:");
      int counter = 0;
      foreach(Potion potion in _potions){
         counter +=1;
         System.Console.WriteLine($"{counter}. {potion.GetItemName()} GV:{potion.GetGoldValue()}");
      }
     }
     public void ListInventoryUpgrades(){
      int counter = 0;
      System.Console.WriteLine("UPGRADES:");
      foreach(Upgrade upgrade in _upgrades){
         counter +=1;
         System.Console.WriteLine($"{counter}. {upgrade.GetItemName()} GV:{upgrade.GetGoldValue()}");
      }
     }
}