namespace _11.Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var trainers = new List<Trainer>();

            string line;
            while ((line = Console.ReadLine()) != "Tournament")
            {
                var info = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var trainerName = info[0];
                var pokemonName = info[1];
                var pokemonElement = info[2];
                var pokemonHealth = int.Parse(info[3]);
                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if (!trainers.Any(a => a.Name == trainerName))
                {
                    trainers.Add(new Trainer(trainerName, 0, new List<Pokemon>() { pokemon }));
                }
                else
                {
                    trainers.Where(a => a.Name == trainerName).First().Pokemons.Add(pokemon);
                }

            }
            string element;
            while ((element = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(a => a.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        //foreach (var pokemon in trainer.Pokemons)
                        //{
                        //    pokemon.Health -= 10;
                        //    if (pokemon.Health <= 0)
                        //    {
                        //        trainer.Pokemons.Remove(pokemon);
                        //        continue;
                        //    }
                        //}
                        for (int i = trainer.Pokemons.Count - 1; i >= 0; i--)
                        {
                            trainer.Pokemons[i].Health -= 10;
                            if (trainer.Pokemons[i].Health <= 0)
                            {
                                trainer.Pokemons.RemoveAt(i);
                            }
                        }
                    }
                }
            }
            foreach (var trainer in trainers.OrderByDescending(a => a.Badges))
            {
                Console.WriteLine("{0} {1} {2}", trainer.Name, trainer.Badges, trainer.Pokemons.Count);
            }
        }
    }
}
