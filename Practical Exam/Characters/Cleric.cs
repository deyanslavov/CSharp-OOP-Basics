using System;

public class Cleric: Character, IHealable
{
    public Cleric(string name, Faction faction):base(name, 50.00, 25.00, 40.00, new Backpack(), faction) { }

    public override double RestHealMultiplier => 0.5;

    public void Heal(Character character)
    {
        if (this.IsAlive && character.IsAlive)
        {
            if (this.Faction != character.Faction)
            {
                throw new ArgumentException(Messages.CannotHealEnemy);
            }

            character.Health += this.AbilityPoints;
        }
    }
}

