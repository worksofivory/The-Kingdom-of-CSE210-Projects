public class Shop{
    Inventory _shopInventory;
    int _shopGold;
    public Shop(Inventory inventory, int gold){
        _shopGold = gold;
        _shopInventory = inventory;
    }
    public Potion SellPotion(string potionName, int cost){
        return null;
    }
    public Upgrade SellUpgrade(string upgradeName, int cost){
        return null;
    }
    public int BuyPotion(){
        return 0;
    }
    public int buyUpgrade(){
        return 0;
    }
}