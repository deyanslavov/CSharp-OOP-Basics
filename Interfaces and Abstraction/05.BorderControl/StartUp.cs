namespace _05.BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var iBuyers = new List<IBuyer>();

            int numberOfPeople = int.Parse(Console.ReadLine());
            ReadBuyers(iBuyers, numberOfPeople);

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (iBuyers.Any(a => a.Name == input))
                {
                    iBuyers.First(a => a.Name == input).BuyFood();
                }
            }

            Console.WriteLine(iBuyers.Sum(a=>a.Food));
        }

        private static void ReadBuyers(List<IBuyer> iBuyers, int numberOfPeople)
        {
            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] data = Console.ReadLine().Split();

                if (data.Length == 4)
                {
                    iBuyers.Add(new Citizen(data[0], int.Parse(data[1]), data[2], data[3]));
                }
                else if (data.Length == 3)
                {
                    iBuyers.Add(new Rebel(data[0], int.Parse(data[1]), data[2]));
                }
            }
        }
    }
}
