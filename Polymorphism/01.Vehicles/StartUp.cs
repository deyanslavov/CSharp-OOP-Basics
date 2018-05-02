namespace _01.Vehicles
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var carInput = Console.ReadLine().Split();
            var truckInput = Console.ReadLine().Split();
            var busInput = Console.ReadLine().Split();

            Vehicle car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]), double.Parse(carInput[3]));
            Vehicle truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]), double.Parse(truckInput[3]));
            Bus bus = new Bus(double.Parse(busInput[1]), double.Parse(busInput[2]), double.Parse(busInput[3]));
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine().Split();

                if (command[0].StartsWith('D'))
                {
                    if (command[0] == "DriveEmpty")
                    {
                        bus.DriveEmpty(double.Parse(command[2]));
                    }
                    else
                    {
                        if (command[1].StartsWith('C'))
                        {
                            car.Drive(double.Parse(command[2]));
                        }
                        else if (command[1].StartsWith('T'))
                        {
                            truck.Drive(double.Parse(command[2]));
                        }
                        else if (command[1].StartsWith('B'))
                        {
                            bus.Drive(double.Parse(command[2]));
                        }
                    }
                }
                else if (command[0].StartsWith('R'))
                {
                    if (command[1].StartsWith('C'))
                    {
                        car.Refuel(double.Parse(command[2]));
                    }
                    else if (command[1].StartsWith('T'))
                    {
                        truck.Refuel(double.Parse(command[2]));
                    }
                    else if (command[1].StartsWith('B'))
                    {
                        bus.Refuel(double.Parse(command[2]));
                    }
                }
            }

            Console.WriteLine($"Car: {car.fuelQuantity:f2}\nTruck: {truck.fuelQuantity:f2}\nBus: {bus.fuelQuantity:f2}");
        }
    }
}
