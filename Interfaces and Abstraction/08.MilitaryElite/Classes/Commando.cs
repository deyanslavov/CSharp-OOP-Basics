using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Commando : SpecialisedSoldier, ICommando
{
    private HashSet<string> missionStates = new HashSet<string>() { "inProgress", "Finished" };

    public HashSet<Mission> Missions { get; private set; }

    public Commando(int id, string firstName, string lastName, double salary, string corps):
        base(id, firstName, lastName, salary, corps)
    {
        this.Missions = new HashSet<Mission>();
    }

    public void AddMission(Mission mission)
    {
        if (missionStates.Any(a => a == mission.State))
        {
            this.Missions.Add(mission);
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString())
            .AppendLine("Missions:");

        foreach (var m in this.Missions)
        {
            sb.AppendLine("  " + m.ToString());
        }
        return sb.ToString().TrimEnd();
    }
}

