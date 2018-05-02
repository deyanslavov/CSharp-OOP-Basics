using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int,Race> races;
    private Garage garage;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        switch (type)
        {
            case "Performance":
                cars.Add(id, new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability, new List<string>()));
                break;
            case "Show":
                cars.Add(id, new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability, 0));
                break;
        }
    }

    public string Check(int id)
    {
        return this.cars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual":
                this.races.Add(id, new CasualRace(length, route, prizePool));
                break;
            case "Drag":
                this.races.Add(id, new DragRace(length, route, prizePool));
                break;
            case "Drift":
                this.races.Add(id, new DriftRace(length, route, prizePool));
                break;
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (this.cars[carId].isParked == false && this.races[raceId].isClosed == false)
        {
            this.cars[carId].isRacing = true;
            this.races[raceId].Participans.Add(this.cars[carId]);
        }
    }

    public string Start(int id)
    {
        if (this.races[id].Participans.Count > 0 && this.races[id].isClosed == false)
        {
            this.cars.Values.All(c => c.isRacing = false);
            this.races[id].isClosed = true;
            return this.races[id].ToString();
        }
        else
        {
            return "Cannot start the race with zero participants.";
        }
    }

    public void Park(int id)
    {
        if (this.cars[id].isRacing == false)
        {
            this.cars[id].isParked  = true;
            this.garage.ParkedCars.Add(id, this.cars[id]);
        }
    }

    public void Unpark(int id)
    {
        this.cars[id].isParked = false;
        this.garage.ParkedCars.Remove(id);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        int[] indices = this.garage.ParkedCars.Select(a => a.Key).ToArray();
        
        if (this.garage.ParkedCars.Count > 0)
        {
            for (int i = 0; i < this.garage.ParkedCars.Count; i++)
            {
                this.garage.ParkedCars[indices[i]].Horsepower += tuneIndex;
                this.garage.ParkedCars[indices[i]].Suspension += (tuneIndex * 50) / 100;

                if (this.garage.ParkedCars[indices[i]].GetType().Name == "ShowCar")
                {
                    ShowCar showCar = (ShowCar)this.garage.ParkedCars[indices[i]];

                    showCar.Stars += tuneIndex;

                    this.garage.ParkedCars[indices[i]] = showCar;
                }
                else
                {
                    PerformanceCar performanceCar = (PerformanceCar)this.garage.ParkedCars[indices[i]];

                    performanceCar.AddOns.Add(addOn);

                    this.garage.ParkedCars[indices[i]] = performanceCar;
                }
            }
        }
    }
}
