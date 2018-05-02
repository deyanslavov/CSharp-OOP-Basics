using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DungeonMaster
{
    private List<Character> characters;
    private Stack<Item> items;
    private int lastSurvivorRounds = 0;
    private ItemFactory ItemFactory;
    private CharacterFactory characterFactory;

    public DungeonMaster()
    {
        this.characters = new List<Character>();
        this.items = new Stack<Item>();
        this.ItemFactory = new ItemFactory();
        this.characterFactory = new CharacterFactory();
    }


    public string JoinParty(string[] args)
    {
        //JoinParty {Java/CSharp} {class} {name}

        var faction = args[0];
        var charType = args[1];
        var name = args[2];

        if (faction == "CSharp" || faction == "Java")
        {
            //if (charType == "Warrior" || charType == "Cleric")
            //{
                Character character = this.characterFactory.CreateCharacter(faction, charType, name);
                characters.Add(character);

                return $"{name} joined the party!";
            //}
            //else
            //{
            //    throw new ArgumentException(string.Format(Messages.InvalidCharacter, charType));
            //}
        }
        else
        {
            throw new ArgumentException(string.Format(Messages.InvalidFaction, faction));
        }
    }

    //private Character CreateChar(string name, string faction, string charType)
    //{
    //    Faction factionEnum = (Faction)Enum.Parse(typeof(Faction), faction);
    //    Character character = null;
    //    switch (charType)
    //    {
    //        case "Warrior":
    //            character = new Warrior(name, factionEnum);
    //            break;
    //        case "Cleric":
    //            character = new Cleric(name, factionEnum);
    //            break;
    //        default:
    //            break;
    //    }
    //    return character;
    //}

    public string AddItemToPool(string[] args)
    {
        //AddItemToPool {itemName}

        var itemName = args[0];

        if (itemName == "ArmorRepairKit" || itemName == "HealthPotion" || itemName == "PoisonPotion")
        {
            Item item = this.ItemFactory.CreateItem(itemName);

            items.Push(item);

            return $"{itemName} added to pool.";
        }
        else
        {
            throw new ArgumentException(string.Format(Messages.InvalidItemName, itemName));
        }

        //Item item = this.ItemFactory.CreateItem(itemName);
        //items.Push(item);
        //return $"{itemName} added to pool.";
    }

    //private Item CreateItem(string itemName)
    //{
    //    Item item = null;

    //    switch (itemName)
    //    {

    //        case "ArmorRepairKit":
    //            item = new ArmorRepairKit();
    //            break;
    //        case "HealthPotion":
    //            item = new HealthPotion();
    //            break;
    //        case "PoisonPotion":
    //            item = new PoisonPotion();
    //            break;
    //        default:
    //            break;
    //    }
    //    return item;
    //}

    public string PickUpItem(string[] args)
    {
        var characterName = args[0];
        if (!this.characters.Any(ch => ch.Name == characterName))
        {
            throw new ArgumentException(string.Format(Messages.CharacterNotFound, characterName));
        }
        if (this.items.Count == 0)
        {
            throw new InvalidOperationException(Messages.NoItemsLeft);
        }
        Item item = this.items.Pop();

        this.characters.First(ch => ch.Name == characterName).Bag.AddItem(item);

        return $"{characterName} picked up {item.GetType().Name}!";
    }

    public string UseItem(string[] args)
    {
        var characterName = args[0];
        var itemName = args[1];

        if (!this.characters.Any(ch => ch.Name == characterName))
        {
            throw new ArgumentException(string.Format(Messages.CharacterNotFound, characterName));
        }
        Item item = this.characters.First(ch => ch.Name == characterName).Bag.GetItem(itemName);
        this.characters.First(ch => ch.Name == characterName).UseItem(item);

        return $"{characterName} used {itemName}.";
    }

    public string UseItemOn(string[] args)
    {
        var giverName = args[0];
        var receiverName = args[1];
        var itemName = args[2];

        if (!this.characters.Any(ch => ch.Name == giverName))
        {
            throw new ArgumentException(string.Format(Messages.CharacterNotFound, giverName));
        }
        if (!this.characters.Any(ch => ch.Name == receiverName))
        {
            throw new ArgumentException(string.Format(Messages.CharacterNotFound, receiverName));
        }
        var giver = this.characters.First(ch => ch.Name == giverName);
        var receiver = this.characters.First(ch => ch.Name == receiverName);
        var item = giver.Bag.GetItem(itemName);
        giver.UseItemOn(item, receiver);

        return $"{giverName} used {itemName} on {receiverName}.";
    }

    public string GiveCharacterItem(string[] args)
    {
        var giverName = args[0];
        var receiverName = args[1];
        var itemName = args[2];

        if (!this.characters.Any(ch => ch.Name == giverName))
        {
            throw new ArgumentException(string.Format(Messages.CharacterNotFound, giverName));
        }
        if (!this.characters.Any(ch => ch.Name == receiverName))
        {
            throw new ArgumentException(string.Format(Messages.CharacterNotFound, receiverName));
        }
        var giver = this.characters.First(ch => ch.Name == giverName);
        var receiver = this.characters.First(ch => ch.Name == receiverName);
        var item = giver.Bag.GetItem(itemName);

        giver.GiveCharacterItem(item, receiver);

        return $"{giverName} gave {receiverName} {itemName}.";
    }

    public string GetStats()
    {
        var sb = new StringBuilder();

        foreach (var character in this.characters.OrderByDescending(ch => ch.IsAlive).ThenByDescending(ch => ch.Health))
        {
            sb.AppendLine(character.ToString());
        }

        return sb.ToString().TrimEnd();
    }

    public string Attack(string[] args)
    {
        var sb = new StringBuilder();

        var attackerName = args[0];
        var receiverName = args[1];

        if (!this.characters.Any(ch => ch.Name == attackerName))
        {
            throw new ArgumentException(string.Format(Messages.CharacterNotFound, attackerName));
        }
        if (!this.characters.Any(ch => ch.Name == receiverName))
        {
            throw new ArgumentException(string.Format(Messages.CharacterNotFound, receiverName));
        }

        var attacker = this.characters.First(ch => ch.Name == attackerName);
        var receiver = this.characters.First(ch => ch.Name == receiverName);

        if (attacker is Cleric)
        {
            throw new ArgumentException(string.Format(Messages.CannotAttack, attackerName));
        }

        var attackerAsWarrior = (Warrior)attacker;
        attackerAsWarrior.Attack(receiver);

        sb.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

        if (!receiver.IsAlive)
        {
            sb.AppendLine($"{receiver.Name} is dead!");
        }

        return sb.ToString().TrimEnd();
    }

    public string Heal(string[] args)
    {
        var healerName = args[0];
        var healingReceiverName = args[1];

        if (!this.characters.Any(ch => ch.Name == healerName))
        {
            throw new ArgumentException(string.Format(Messages.CharacterNotFound, healerName));
        }
        if (!this.characters.Any(ch => ch.Name == healingReceiverName))
        {
            throw new ArgumentException(string.Format(Messages.CharacterNotFound, healingReceiverName));
        }

        var healer = this.characters.First(ch => ch.Name == healerName);
        var receiver = this.characters.First(ch => ch.Name == healingReceiverName);

        if (healer is Warrior)
        {
            throw new ArgumentException(string.Format(Messages.CannotHeal, healerName));
        }

        Cleric healerAsCleric = (Cleric)healer;

        healerAsCleric.Heal(receiver);


        return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";
    }

    public string EndTurn(string[] args)
    {
        var sb = new StringBuilder();

        foreach (var character in this.characters.Where(ch => ch.IsAlive))
        {
            var currentHealth = character.Health;

            character.Rest();

            sb.AppendLine($"{character.Name} rests ({currentHealth} => {character.Health})");
        }

        if (this.characters.Where(ch => ch.IsAlive).Count() <= 1)
        {
            this.lastSurvivorRounds++;
        }

        return sb.ToString().TrimEnd();
    }

    public bool IsGameOver()
    {
        if (this.lastSurvivorRounds > 1)
        {
            return true;
        }
        return false;
    }

}
