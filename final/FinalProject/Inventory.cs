public class Inventory{
     List<Potion> _potions;
     List<Upgrade> _upgrades;

     public void AddPotion(Potion potion){
      _potions.Add(potion);
     }
     public void AddUpgrade(Upgrade upgrade){
      _upgrades.Add(upgrade);
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
     public Upgrade GetInventoryUpgrade(string name){
        foreach(Upgrade upgrade in _upgrades){
            if(upgrade.GetItemName().ToLower()==name.ToLower()){
               return upgrade;
            }else{
               System.Console.WriteLine("That's not available...");
               return null;
            }
        }
        System.Console.WriteLine("That's not available...");
        return null;
     }
     public void ListInventory(){
      System.Console.WriteLine("POTIONS:");
      int counter = 0;
      foreach(Potion potion in _potions){
         counter +=1;
         System.Console.Write($"{counter}. {potion.GetItemName()} GV:{potion.GetGoldValue()}");
      }
      counter = 0;
      System.Console.WriteLine("UPGRADES:");
      foreach(Upgrade upgrade in _upgrades){
         counter +=1;
         System.Console.WriteLine($"{counter}. {upgrade.GetItemName()} GV:{upgrade.GetGoldValue()}");
      }
     }
}