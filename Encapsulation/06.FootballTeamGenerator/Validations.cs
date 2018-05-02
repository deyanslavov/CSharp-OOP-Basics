using System;

public class Validations
{
    public static void ValidateEndurance(int stat)
    {
        if (stat < 0 || stat > 100)
        {
            throw new ArgumentException("Endurance should be between 0 and 100.");
        }
    }
    public static void ValidateSprint(int stat)
    {
        if (stat < 0 || stat > 100)
        {
            throw new ArgumentException("Sprint should be between 0 and 100.");
        }
    }
    public static void ValidateDribble(int stat)
    {
        if (stat < 0 || stat > 100)
        {
            throw new ArgumentException("Dribble should be between 0 and 100.");
        }
    }
    public static void ValidatePassing(int stat)
    {
        if (stat < 0 || stat > 100)
        {
            throw new ArgumentException("Shooting should be between 0 and 100.");
        }
    }
    public static void ValidateShooting(int stat)
    {
        if (stat < 0 || stat > 100)
        {
            throw new ArgumentException("Endurance should be between 0 and 100.");
        }
    }

    public static void ValidateName(string name)
    {
        if (string.IsNullOrEmpty(name) || name == " ")
        {
            throw new ArgumentException("A name should not be empty.");
        }
    }
}

