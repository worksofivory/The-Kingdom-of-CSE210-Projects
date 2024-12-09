public class Shop{
    Inventory _shopInventory;
    int _shopGold;
    public Shop(Inventory inventory, int gold){
        _shopGold = gold;
        _shopInventory = inventory;
    }
    public Potion SellPotion(string potionName, int goldHeld){
        if(goldHeld >= _shopInventory.GetInventoryPotion(potionName).GetGoldValue()){
            return _shopInventory.GetInventoryPotion(potionName);
        }else{
            System.Console.WriteLine("You don't have enough gold for that...");
            return null;
        }
    }
    public Upgrade SellUpgrade(string upgradeName, int goldHeld){
        if(goldHeld >= _shopInventory.GetInventoryUpgrade(upgradeName).GetGoldValue()){
            return _shopInventory.GetInventoryUpgrade(upgradeName);
        }else{
            System.Console.WriteLine("You don't have enough gold for that...");
            return null;
        }        
    }
    public int BuyPotion(Potion potion){
        _shopInventory.AddPotion(potion);
        _shopGold -= potion.GetGoldValue();
        return potion.GetGoldValue();
    }
    public int buyUpgrade(Upgrade upgrade){
        _shopInventory.AddUpgrade(upgrade);
        _shopGold -= upgrade.GetGoldValue();
        return upgrade.GetGoldValue();
    }
}