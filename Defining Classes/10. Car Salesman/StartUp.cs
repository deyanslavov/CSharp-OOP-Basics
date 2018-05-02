namespace _10.Car_Salesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var cars = new List<Car>();
            var engines = new List<Engine>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var engineInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var engine = new Engine();
                var model = engineInput[0];
                var power = int.Parse(engineInput[1]);
                engine.Model = model;
                engine.Power = power;
                if (engineInput.Length == 3)
                {
                    if (int.TryParse(engineInput[2], out int displacement))
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        engine.Efficiency = engineInput[2];
                    }
                }
                else if (engineInput.Length == 4)
                {
                    engine.Displacement = int.Parse(engineInput[2]);
                    engine.Efficiency = engineInput[3];
                }
                engines.Add(engine);
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                var carInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var car = new Car();
                var model = carInput[0];
                var engine = engines.Where(a => a.Model == carInput[1]).First();
                car.Model = model;
                car.Engine = engine;
                if (carInput.Length == 3)
                {
                    if (int.TryParse(carInput[2], out int weight))
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = carInput[2];
                    }
                }
                else if (carInput.Length == 4)
                {
                    car.Weight = int.Parse(carInput[2]);
                    car.Color = carInput[3];
                }
                cars.Add(car);
            }
            cars.ForEach(a => Console.WriteLine(a.ToString()));
        }
    }
}
