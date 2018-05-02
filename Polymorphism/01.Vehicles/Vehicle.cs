public abstract class Vehicle
{
    protected double tankCapacity;

    public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.fuelConsumption = fuelConsumption;
        this.fuelQuantity = fuelQuantity;
        this.TankCapacity = tankCapacity;
    }

    public double fuelQuantity;

    public double fuelConsumption;

    public double TankCapacity
    {
        get { return this.tankCapacity; }
        private set
        {
            if (value < fuelQuantity)
            {
                fuelQuantity = 0;
            }
            tankCapacity = value;
        }
    }

    public abstract void Drive(double distance);

    public abstract void Refuel(double litersAmount);
}

