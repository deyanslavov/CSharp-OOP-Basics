namespace _12.Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var people = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                switch (tokens[1])
                {
                    case "company":
                        var companyName = tokens[2];
                        var department = tokens[3];
                        var salary = decimal.Parse(tokens[4]);
                        var company = new Company(companyName, department, salary);
                        if (!people.Any(a => a.Name == name))
                        {
                            people.Add(new Person { Name = name, Company = company });
                        }
                        else
                        {
                            people.First(a => a.Name == name).Company = company;
                        }
                        break;

                    case "pokemon":
                        var pokemonName = tokens[2];
                        var pokemonType = tokens[3];
                        if (!people.Any(a => a.Name == name))
                        {
                            people.Add(new Person { Name = name });
                            people.First(a => a.Name == name).Pokemons.Add(new Pokemon(pokemonName, pokemonType));
                        }
                        else
                        {
                            people.First(a => a.Name == name).Pokemons.Add(new Pokemon(pokemonName, pokemonType));
                        }
                        break;

                    case "parents":
                        var parentName = tokens[2];
                        var parentBirthday = tokens[3];
                        if (!people.Any(a => a.Name == name))
                        {
                            people.Add(new Person { Name = name });
                            people.First(a => a.Name == name).Parents.Add(new Parent(parentName, parentBirthday));
                        }
                        else
                        {
                            people.First(a => a.Name == name).Parents.Add(new Parent(parentName, parentBirthday));
                        }
                        break;

                    case "children":
                        var childName = tokens[2];
                        var childBirthday = tokens[3];
                        if (!people.Any(a => a.Name == name))
                        {
                            people.Add(new Person { Name = name });
                            people.First(a => a.Name == name).Children.Add(new Child(childName, childBirthday));
                        }
                        else
                        {
                            people.First(a => a.Name == name).Children.Add(new Child(childName, childBirthday));
                        }
                        break;

                    case "car":
                        var model = tokens[2];
                        var speed = int.Parse(tokens[3]);
                        if (!people.Any(a => a.Name == name))
                        {
                            people.Add(new Person { Name = name, Car = new Car(model, speed) });
                        }
                        else
                        {
                            people.First(a => a.Name == name).Car = new Car(model, speed);
                        }
                        break;
                }
            }
            string printName = Console.ReadLine();
            Console.WriteLine(people.First(a => a.Name == printName).ToString());
        }
    }
}
