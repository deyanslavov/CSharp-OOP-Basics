namespace _03.WildFarm
{
    class StartUp
    {
        public static void Main()
        {
            var animals = new List<Animal>();
            int counter = 0;

            ReadAndFeedAnimals(animals, counter);
            PrintAnimals(animals);

        }
        private static void PrintAnimals(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
        private static void ReadAndFeedAnimals(List<Animal> animals, int counter)
        {
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                var tokens = line.Split();
                if (counter == 0)
                {
                    switch (tokens[0])
                    {
                        case "Hen":
                            CreateAndAddHen(animals, tokens);
                            break;
                        case "Owl":
                            CreateAndAddOwl(animals, tokens);
                            break;
                        case "Mouse":
                            CreateAndAddMouse(animals, tokens);
                            break;
                        case "Cat":
                            CreateAndAddCat(animals, tokens);
                            break;
                        case "Dog":
                            CreateAndAddDog(animals, tokens);
                            break;
                        case "Tiger":
                            CreateAndAddTiger(animals, tokens);
                            break;
                        default:
                            break;
                    }
                    counter = 1;
                }
                else
                {
                    switch (tokens[0])
                    {
                        case "Vegetable":
                            FeedWithVegetable(animals, tokens);
                            break;
                        case "Fruit":
                            FeedWithFruit(animals, tokens);
                            break;
                        case "Meat":
                            FeedWithMeat(animals, tokens);
                            break;
                        case "Seeds":
                            FeedWithSeeds(animals, tokens);
                            break;
                    }
                    counter = 0;
                }
            }
        }
        private static void FeedWithVegetable(List<Animal> animals, string[] tokens)
        {
            animals.Last().Eat(new Vegetable(int.Parse(tokens[1])));
        }
        private static void FeedWithFruit(List<Animal> animals, string[] tokens)
        {
            animals.Last().Eat(new Fruit(int.Parse(tokens[1])));
        }
        private static void FeedWithMeat(List<Animal> animals, string[] tokens)
        {
            animals.Last().Eat(new Meat(int.Parse(tokens[1])));
        }
        private static void FeedWithSeeds(List<Animal> animals, string[] tokens)
        {
            animals.Last().Eat(new Seeds(int.Parse(tokens[1])));
        }
        private static void CreateAndAddHen(List<Animal> animals, string[] tokens)
        {
            animals.Add(new Hen(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3])));
        }
        private static void CreateAndAddOwl(List<Animal> animals, string[] tokens)
        {
            animals.Add(new Owl(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3])));
        }
        private static void CreateAndAddMouse(List<Animal> animals, string[] tokens)
        {
            animals.Add(new Mouse(tokens[1], double.Parse(tokens[2]), tokens[3]));
        }
        private static void CreateAndAddCat(List<Animal> animals, string[] tokens)
        {
            animals.Add(new Cat(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]));
        }
        private static void CreateAndAddDog(List<Animal> animals, string[] tokens)
        {
            animals.Add(new Dog(tokens[1], double.Parse(tokens[2]), tokens[3]));
        }
        private static void CreateAndAddTiger(List<Animal> animals, string[] tokens)
        {
            animals.Add(new Tiger(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]));
        }
    }
}
