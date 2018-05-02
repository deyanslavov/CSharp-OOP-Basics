namespace _06.Animals
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string line;
            while ((line = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    if (line == "Dog")
                    {
                        var info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        var dog = new Dog(info[0], int.Parse(info[1]), info[2]);

                        Console.WriteLine(dog);
                        dog.ProduceSound();
                    }
                    else if (line == "Cat")
                    {
                        var info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        var cat = new Cat(info[0], int.Parse(info[1]), info[2]);

                        Console.WriteLine(cat);
                        cat.ProduceSound();
                    }
                    else if (line == "Frog")
                    {
                        var info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        var frog = new Frog(info[0], int.Parse(info[1]), info[2]);

                        Console.WriteLine(frog);
                        frog.ProduceSound();
                    }
                    else if (line == "Kitten")
                    {
                        var info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        var kitten = new Kitten(info[0], int.Parse(info[1]));

                        Console.WriteLine(kitten);
                        kitten.ProduceSound();
                    }
                    else if (line == "Tomcat")
                    {
                        var info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        var tomcat = new Tomcat(info[0], int.Parse(info[1]));

                        Console.WriteLine(tomcat);
                        tomcat.ProduceSound();
                    }
                    else
                    {
                        throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
