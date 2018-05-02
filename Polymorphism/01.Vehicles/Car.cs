using System;

public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override void Drive(double distance)
    {
        if (fuelQuantity >= (fuelConsumption + 0.9) * distance)
        {
            fuelQuantity -= (fuelConsumption + 0.9) * distance;
            Console.WriteLine($"Car travelled {distance} km");
        }
        else
        {
            Console.WriteLine("Car needs refueling");
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

