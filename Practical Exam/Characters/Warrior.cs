using System;

public class Warrior: Character, IAttackable
{
    public Warrior(string name, Faction faction):base(name, 100.00, 50.00, 40.00, new Satchel(), faction)
    {

    }

    public void Attack(Character character)
    {
        if (this.IsAlive && character.IsAlive)
        {
            if (this.Name == character.Name)
            {
                throw new InvalidOperationException(Messages.CannotAttackSelf);
            }
            if (this.Faction == character.Faction)
            {
                throw new ArgumentException(string.Format(Messages.FriendlyFire, this.Faction));
            }

            character.TakeDamage(this.AbilityPoints);
        }
    }
}

