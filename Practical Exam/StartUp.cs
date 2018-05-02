namespace DungeonsAndCodeWizards
{
    using System;
    using System.Linq;

    public class StartUp
    {
        // DO NOT rename this file's namespace or class name.
        // However, you ARE allowed to use your own namespaces (or no namespaces at all if you prefer) in other classes.
        public static void Main()
        {
            var dm = new DungeonMaster();
            while (true)
            {
                try
                {
                    if (dm.IsGameOver())
                    {
                        break;
                    }
                    string line = Console.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        break;
                    }
                    var command = line.Split()[0];

                    var tokens = line.Split().Skip(1).ToArray();

                    switch (command)
                    {
                        case "JoinParty":
                            Console.WriteLine(dm.JoinParty(tokens));
                            break;
                        case "AddItemToPool":
                            Console.WriteLine(dm.AddItemToPool(tokens));
                            break;
                        case "PickUpItem":
                            Console.WriteLine(dm.PickUpItem(tokens));
                            break;
                        case "UseItem":
                            Console.WriteLine(dm.UseItem(tokens));
                            break;
                        case "UseItemOn":
                            Console.WriteLine(dm.UseItemOn(tokens));
                            break;
                        case "GiveCharacterItem":
                            Console.WriteLine(dm.GiveCharacterItem(tokens));
                            break;
                        case "GetStats":
                            Console.WriteLine(dm.GetStats());
                            break;
                        case "Attack":
                            Console.WriteLine(dm.Attack(tokens));
                            break;
                        case "Heal":
                            Console.WriteLine(dm.Heal(tokens));
                            break;
                        case "EndTurn":
                            Console.WriteLine(dm.EndTurn(tokens));
                            if (dm.IsGameOver())
                            {
                                break;
                            }
                            break;
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Parameter Error: " + e.Message);
                }
                catch(InvalidOperationException e)
                {
                    Console.WriteLine("Invalid Operation: "+ e.Message);
                }
            }
            Console.WriteLine("Final stats:");
            Console.WriteLine(dm.GetStats());
        }
    }
}