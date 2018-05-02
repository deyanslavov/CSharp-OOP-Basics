using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatar
{
    class Program
    {
        static void Main(string[] args)
        {
            var nb = new NationsBuilder();
            
            while (true)
            {
                var input = Console.ReadLine().Split().ToList();

                switch (input[0])
                {
                    case "Bender":
                        nb.AssignBender(input);
                        break;
                    case "Monument":
                        nb.AssignMonument(input);
                        break;
                    case "Status":
                        Console.WriteLine(nb.GetStatus(input[1]));
                        break;
                    case "War":
                        nb.IssueWar(input[1]);
                        break;
                    case "Quit":
                        Console.WriteLine(nb.GetWarsRecord());
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
