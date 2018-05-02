namespace _05.PizzaCalories
{
    using System;

    class StartUp
    {
        static void Main()
        {
            try
            {
                Pizza pizza = ReadPizza();
                Dough dough = ReadDough();
                pizza.SetDought(dough);
                ReadAndAddToppings(pizza);
                Console.WriteLine($"{pizza.Name} - {pizza.Calories:F2} Calories.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ReadAndAddToppings(Pizza pizza)
        {
            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                var tokens = line.Split();
                var topping = new Topping(tokens[1], double.Parse(tokens[2]));
                pizza.AddTopping(topping);
            }
        }

        private static Dough ReadDough()
        {
            var input = Console.ReadLine().Split();
            Dough dough = new Dough(double.Parse(input[3]), input[1], input[2]);
            return dough;
        }

        private static Pizza ReadPizza()
        {
            var input = Console.ReadLine().Split();
            Pizza pizza = new Pizza(input[1]);
            return pizza;
        }
    }
}
