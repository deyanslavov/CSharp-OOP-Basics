using System;

class Car
{
    private string model;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    private double fuelAmount;

    public double FuelAmount
    {
        get { return fuelAmount; }
        set { fuelAmount = value; }
    }

    private double consumption;

    public double Consumption
    {
        get { return consumption; }
        set { consumption = value; }
    }

    private double distanceTravelled = 0;

    public double DistanceTravelled
    {
        get { return distanceTravelled; }
        set { distanceTravelled = value; }
    }

    public void Drive(double km)
    {
        double usedFuel = this.consumption * km;
        if (fuelAmount >= usedFuel)
        {
            this.fuelAmount -= usedFuel;
            this.distanceTravelled += km;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public Car()
    {

    }
    public Car(string model, double fuelAmount, double consumption, double distanceTravelled)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.consumption = consumption;
        this.distanceTravelled = distanceTravelled;
    }
}

