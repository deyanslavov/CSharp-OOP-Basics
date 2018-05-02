using System;

public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override void Drive(double distance)
    {
        if (fuelQuantity >= (fuelConsumption + 1.4) * distance)
        {
            fuelQuantity -= (fuelConsumption + 1.4) * distance;
            Console.WriteLine($"Bus travelled {distance} km");
        }
        else
        {
            Console.WriteLine("Bus needs refueling");
        }
    }

    public void DriveEmpty(double distance)
    {
        if (fuelQuantity >= fuelConsumption * distance)
        {
            fuelQuantity -= fuelConsumption * distance;
            Console.WriteLine($"Bus travelled {distance} km");
        }
        else
        {
            Console.WriteLine("Bus needs refueling");
        }
    }

    public override void Refuel(double litersAmount)
    {
        if (litersAmount <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else if (tankCapacity < litersAmount + fuelQuantity)
        {
            Console.WriteLine($"Cannot fit {litersAmount} fuel in the tank");
        }
        else
        {
            fuelQuantity += litersAmount;
        }
    }
}

