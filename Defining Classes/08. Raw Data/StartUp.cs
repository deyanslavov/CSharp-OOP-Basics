namespace _08.Raw_Data
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
                var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var engine = new Engine { Speed = int.Parse(carInfo[1]), Power = int.Parse(carInfo[2]) };
                var cargo = new Cargo { Weight = int.Parse(carInfo[3]), Type = carInfo[4] };
                var tires = new List<Tire>();
                for (int j = 5; j < carInfo.Length; j+=2)
                {
                    var tire = new Tire();
                    tire.Pressure = double.Parse(carInfo[j]);
                    tire.Age = int.Parse(carInfo[j + 1]);
                    tires.Add(tire);
                }
                var car = new Car { Model = carInfo[0], Engine = engine, Cargo = cargo, Tires = tires };
                cars.Add(car);
            }

            var command = Console.ReadLine();
            if (command == "fragile")
            {
                cars.Where(a => a.Cargo.Type == "fragile" && a.Tires.Any(b => b.Pressure < 1)).ToList().ForEach(a => Console.WriteLine($"{a.Model}"));
            }
            else
            {
                cars.Where(a => a.Cargo.Type == "flamable" && a.Engine.Power > 250).ToList().ForEach(a => Console.WriteLine($"{a.Model}"));
            }
        }
    }
}
