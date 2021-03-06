﻿using System;
using System.Linq;

namespace Exam_Preparation_I___Need_For_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new CarManager();

            string line;
            while ((line = Console.ReadLine()) != "Cops Are Here")
            {
                var tokens = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (tokens[0])
                {
                    case "register":
                        manager.Register(int.Parse(tokens[1]), tokens[2], tokens[3], tokens[4], int.Parse(tokens[5]), int.Parse(tokens[6]), int.Parse(tokens[7]), int.Parse(tokens[8]), int.Parse(tokens[9]));
                        break;
                    case "check":
                        Console.WriteLine(manager.Check(int.Parse(tokens[1])));
                        break;
                    case "open":
                        manager.Open(int.Parse(tokens[1]), tokens[2], int.Parse(tokens[3]), tokens[4], int.Parse(tokens[5]));
                        break;
                    case "participate":
                        manager.Participate(int.Parse(tokens[1]), int.Parse(tokens[2]));
                        break;
                    case "start":
                        Console.WriteLine(manager.Start(int.Parse(tokens[1])));
                        break;
                    case "park":
                        manager.Park(int.Parse(tokens[1]));
                        break;
                    case "unpark":
                        manager.Unpark(int.Parse(tokens[1]));
                        break;
                    case "tune":
                        manager.Tune(int.Parse(tokens[1]), tokens[2]);
                        break;
                }
            }
        }
    }
}
