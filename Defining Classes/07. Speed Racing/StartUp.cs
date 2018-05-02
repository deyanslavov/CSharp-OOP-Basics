namespace _07.Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var carDetails = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var model = carDetails[0];
                var fuelAmount = double.Parse(carDetails[1]);
                var consumption = double.Parse(carDetails[2]);

                var car = new Car() { Model = model, FuelAmount = fuelAmount, Consumption = consumption };
                cars.Add(car);
            }
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                var tokens = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var currentCar = cars.Where(a => a.Model == tokens[1]).First();
                currentCar.Drive(double.Parse(tokens[2]));
            }
            cars.ForEach(a => Console.WriteLine($"{a.Model} {a.FuelAmount:f2} {a.DistanceTravelled}"));
        }
    }
}
