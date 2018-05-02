namespace _14.Cat_Lady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var cats = new List<Cat>();

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                var tokens = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var breed = tokens[0];
                var name = tokens[1];
                var characteristic = double.Parse(tokens[2]);

                if (!cats.Any(a => a.Name == name))
                {
                    cats.Add(new Cat(name, breed, characteristic));
                }
                else
                {
                    cats.First(a => a.Name == name).Characteristic = characteristic;
                }
            }

            var catName = Console.ReadLine();
            Console.WriteLine(cats.First(a => a.Name == catName).ToString());
        }
    }
}
