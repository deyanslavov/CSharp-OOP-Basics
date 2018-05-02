namespace _08.MilitaryElite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var allSoldiers = new List<ISoldier>();
            ReadSoldiers(allSoldiers);
            PrintSoldiers(allSoldiers);
        }

        private static void PrintSoldiers(List<ISoldier> allSoldiers)
        {
            foreach (var soldier in allSoldiers)
            {
                Console.WriteLine(soldier);
            }
        }

        private static void ReadSoldiers(List<ISoldier> allSoldiers)
        {
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                var tokens = line.Split();

                switch (tokens[0])
                {
                    case "Private":
                        AddPrivate(allSoldiers, tokens);
                        break;
                    case "LeutenantGeneral":
                        AddLeutenantGeneral(allSoldiers, tokens);
                        break;
                    case "Engineer":
                        AddEngineer(allSoldiers, tokens);
                        break;
                    case "Commando":
                        AddCommando(allSoldiers, tokens);
                        break;
                    case "Spy":
                        AddSpy(allSoldiers, tokens);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void AddPrivate(List<ISoldier> allSoldiers, string[] tokens)
        {
            var @private = new Private(int.Parse(tokens[1]), tokens[2], tokens[3], double.Parse(tokens[4]));
            allSoldiers.Add(@private);
        }

        private static void AddLeutenantGeneral(List<ISoldier> allSoldiers, string[] tokens)
        {
            var lGeneral = new LeutenantGeneral(int.Parse(tokens[1]), tokens[2], tokens[3], double.Parse(tokens[4]));

            for (int i = 5; i < tokens.Length; i++)
            {
                Private currentPrivate = (Private)allSoldiers.First(a => a.Id == int.Parse(tokens[i]));
                lGeneral.Privates.Add(currentPrivate);
            }
            allSoldiers.Add(lGeneral);
        }

        private static void AddEngineer(List<ISoldier> allSoldiers, string[] tokens)
        {
            var engineer = new Engineer(int.Parse(tokens[1]), tokens[2], tokens[3], double.Parse(tokens[4]), tokens[5]);
            if (engineer.Corps != null)
            {
                for (int i = 6; i < tokens.Length; i+=2)
                {
                    var repair = new Repair(tokens[i], int.Parse(tokens[i + 1]));
                    engineer.Repairs.Add(repair);
                }
                allSoldiers.Add(engineer);
            }
        }

        private static void AddCommando(List<ISoldier> allSoldiers, string[] tokens)
        {
            var commando = new Commando(int.Parse(tokens[1]), tokens[2], tokens[3], double.Parse(tokens[4]), tokens[5]);
            if (commando.Corps != null)
            {
                for (int i = 6; i < tokens.Length; i+=2)
                {
                    var missions = new Mission(tokens[i], tokens[i + 1]);
                    commando.AddMission(missions);
                }
                allSoldiers.Add(commando);
            }
        }

        private static void AddSpy(List<ISoldier> allSoldiers, string[] tokens)
        {
            var spy = new Spy(int.Parse(tokens[1]), tokens[2], tokens[3], int.Parse(tokens[4]));
            allSoldiers.Add(spy);
        }
    }
}
