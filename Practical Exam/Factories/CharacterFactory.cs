using System;

public class CharacterFactory
{
    public Character CreateCharacter(string faction, string charType, string name)
    {
        Faction factionEnum = (Faction)Enum.Parse(typeof(Faction), faction);
        Character character = null;
        switch (charType)
        {
            case "Warrior":
                character = new Warrior(name, factionEnum);
                break;
            case "Cleric":
                character = new Cleric(name, factionEnum);
                break;
            default:
                throw new ArgumentException(string.Format(Messages.InvalidCharacter, charType));
        }
        return character;
    }
}

