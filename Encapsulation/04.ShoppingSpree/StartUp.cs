namespace _04.ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            try
            {
                var people = ReadPeople();
                var products = ReadProducts();
                BuyProductsAndPrint(people, products);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void BuyProductsAndPrint(List<Person> people, List<Product> products)
        {
            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                var tokens = line.Split();
                var product = products.First(p => p.Name == tokens[1]);
                people.First(p => p.Name == tokens[0]).BuyProduct(product);
            }
            people.ForEach(p => Console.WriteLine(p));
        }

        private static List<Product> ReadProducts()
        {
            var products = new List<Product>();
            var input = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i += 2)
            {
                var product = new Product(input[i], decimal.Parse(input[i + 1]));
                products.Add(product);
            }
            return products;
        }

        private static List<Person> ReadPeople()
        {
            var people = new List<Person>();
            var input = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i+=2)
            {
                var person = new Person(input[i], decimal.Parse(input[i+1]));
                people.Add(person);
            }
            return people;
        }
    }
}
