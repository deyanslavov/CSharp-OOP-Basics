using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DragRace : Race
{
    public DragRace(int length, string route, int prizePool) : base(length, route, prizePool) { }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(base.ToString());

        this.Participans = this.Participans.OrderByDescending(p => p.EnginePerformace).ToList();

        if (this.Participans.Count == 1)
        {
            sb.AppendLine($"1. {this.Participans[0].Brand} {this.Participans[0].Model} {this.Participans[0].EnginePerformace}PP - ${(this.PrizePool * 50) / 100}");
        }
        else if (this.Participans.Count == 2)
        {
            sb.AppendLine($"1. {this.Participans[0].Brand} {this.Participans[0].Model} {this.Participans[0].EnginePerformace}PP - ${(this.PrizePool * 50) / 100}");
            sb.AppendLine($"2. {this.Participans[1].Brand} {this.Participans[1].Model} {this.Participans[1].EnginePerformace}PP - ${(this.PrizePool * 30) / 100}");
        }
        else
        {
            sb.AppendLine($"1. {this.Participans[0].Brand} {this.Participans[0].Model} {this.Participans[0].EnginePerformace}PP - ${(this.PrizePool * 50) / 100}");
            sb.AppendLine($"2. {this.Participans[1].Brand} {this.Participans[1].Model} {this.Participans[1].EnginePerformace}PP - ${(this.PrizePool * 30) / 100}");
            sb.AppendLine($"3. {this.Participans[2].Brand} {this.Participans[2].Model} {this.Participans[2].EnginePerformace}PP - ${(this.PrizePool * 20) / 100}");
        }

        return sb.ToString().TrimEnd();
    }
}
