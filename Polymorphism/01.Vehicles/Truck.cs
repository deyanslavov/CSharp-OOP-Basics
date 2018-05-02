using System;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override void Drive(double distance)
    {
        if (fuelQuantity >= (fuelConsumption + 1.6) * distance)
        {
            fuelQuantity -= (fuelConsumption + 1.6) * distance;
            Console.WriteLine($"Truck travelled {distance} km");
        }
        else
        {
            Console.WriteLine("Truck needs refueling");
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
            fuelQuantity += litersAmount * 0.95;
        }
    }
}

