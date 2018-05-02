using System;

public class ItemFactory
{
    public Item CreateItem(string itemName)
    {
        Item item = null;

        switch (itemName)
        {
            case "ArmorRepairKit":
                item = new ArmorRepairKit();
                break;
            case "HealthPotion":
                item = new HealthPotion();
                break;
            case "PoisonPotion":
                item = new PoisonPotion();
                break;
            default:
                throw new ArgumentException(string.Format(Messages.InvalidItemName, itemName));
        }
        return item;
    }
}

