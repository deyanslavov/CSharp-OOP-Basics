using System;

public abstract class Character
{
    protected Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
    {
        this.Name = name;
        this.BaseHealth = health;
        this.BaseArmor = armor;
        this.AbilityPoints = abilityPoints;
        this.Bag = bag;
        this.Faction = faction;
        this.Health = this.BaseHealth;
        this.Armor = this.BaseArmor;
        this.IsAlive = true;
        this.RestHealMultiplier = 0.2;
    }

    private string name;

    public string Name
    {
        get { return name; }
        protected set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(Messages.InvalidName);
            }
            name = value;
        }
    }

    public double BaseHealth { get; }

    public double Health { get; set; }

    public double BaseArmor { get; }

    public double Armor { get; set; }

    public double AbilityPoints { get; }

    public Bag Bag { get; }

    public Faction Faction { get; }

    public bool IsAlive { get; set; }

    public virtual double RestHealMultiplier { get; }

    public void TakeDamage(double hitPoints)
    {
        if (this.IsAlive)
        {
            if (this.Armor >= hitPoints)
            {
                this.Armor -= hitPoints;
            }
            else
            {
                var diff = Math.Abs(this.Armor - hitPoints);
                this.Armor = 0;
                this.Health -= diff;
                if (this.Health <= 0)
                {
                    this.Health = 0;
                    this.IsAlive = false;
                }
            }
        }
        else
        {
            throw new InvalidOperationException(Messages.MustBeAlive);
        }
    }

    public void Rest()
    {
        if (this.IsAlive)
        {
            this.Health += this.BaseHealth * this.RestHealMultiplier;
            if (this.Health > this.BaseHealth)
            {
                this.Health = this.BaseHealth;
            }
        }
        else
        {
            throw new InvalidOperationException(Messages.MustBeAlive);
        }
    }

    public void UseItem(Item item)
    {
        if (this.IsAlive)
        {
            item.AffectCharacter(this);
        }
        else
        {
            throw new InvalidOperationException(Messages.MustBeAlive);
        }
    }

    public void UseItemOn(Item item, Character character)
    {
        if (this.IsAlive && character.IsAlive)
        {
            item.AffectCharacter(character);
        }
        else
        {
            throw new InvalidOperationException(Messages.MustBeAlive);
        }
    }

    public void GiveCharacterItem(Item item, Character character)
    {
        if (this.IsAlive && character.IsAlive)
        {
            character.Bag.AddItem(item);
        }
        else
        {
            throw new InvalidOperationException(Messages.MustBeAlive);
        }
    }

    public void ReceiveItem(Item item)
    {
        if (this.IsAlive)
        {
            this.Bag.AddItem(item);
        }
        else
        {
            throw new InvalidOperationException(Messages.MustBeAlive);
        }
    }

    public override string ToString()
    {
        var status = this.IsAlive ? "Alive" : "Dead";

        return $"{Name} - HP: {Health}/{BaseHealth}, AP: {Armor}/{BaseArmor}, Status: {status}";
    }
}

