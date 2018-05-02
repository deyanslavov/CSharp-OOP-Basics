using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NationsBuilder
{
    private List<AirBender> airBenders;
    private List<FireBender> fireBenders;
    private List<WaterBender> waterBenders;
    private List<EarthBender> earthBenders;
    private List<Monument> monuments;
    private List<string> warsSequence;

    public NationsBuilder()
    {
        this.airBenders = new List<AirBender>();
        this.fireBenders = new List<FireBender>();
        this.waterBenders = new List<WaterBender>();
        this.earthBenders = new List<EarthBender>();
        this.monuments = new List<Monument>();
        this.warsSequence = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        switch (benderArgs[1])
        {
            case "Air":airBenders.Add(new AirBender(benderArgs[2], int.Parse(benderArgs[3]), double.Parse(benderArgs[4])));
                break;
            case "Water":waterBenders.Add(new WaterBender(benderArgs[2], int.Parse(benderArgs[3]), double.Parse(benderArgs[4])));
                break;
            case "Fire":fireBenders.Add(new FireBender(benderArgs[2], int.Parse(benderArgs[3]), double.Parse(benderArgs[4])));
                break;
            case "Earth":earthBenders.Add(new EarthBender(benderArgs[2], int.Parse(benderArgs[3]), double.Parse(benderArgs[4])));
                break;
        }
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        Monument monument = null;
        switch (monumentArgs[1])
        {
            case "Air":
                monument = new AirMonument(monumentArgs[2], int.Parse(monumentArgs[3]));
                break;
            case "Water":
                monument = new WaterMonument(monumentArgs[2], int.Parse(monumentArgs[3]));
                break;
            case "Fire":
                monument = new FireMonument(monumentArgs[2], int.Parse(monumentArgs[3]));
                break;
            case "Earth":
                monument = new EarthMonument(monumentArgs[2], int.Parse(monumentArgs[3]));
                break;
            default:
                break;
        }
        monuments.Add(monument);
    }

    public string GetStatus(string nationsType)
    {
        var sb = new StringBuilder();

        sb = GetStatusForNation(nationsType);
        
        return sb.ToString().TrimEnd();
    }

    private StringBuilder GetStatusForNation(string nationsType)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{nationsType} Nation");
            
        switch (nationsType)
        {
            case "Air":
                if (airBenders.Count == 0)
                {
                    sb.AppendLine("Benders: None");
                }
                else
                {
                    sb.AppendLine("Benders:");
                    foreach (var bender in airBenders)
                    {
                        sb.AppendLine("###" + bender.ToString());
                    }
                }
                break;
            case "Water":
                if (waterBenders.Count == 0)
                {
                    sb.AppendLine("Benders: None");
                }
                else
                {
                    sb.AppendLine("Benders:");
                    foreach (var bender in waterBenders)
                    {
                        sb.AppendLine("###" + bender.ToString());
                    }
                }
                break;
            case "Fire":
                if (fireBenders.Count == 0)
                {
                    sb.AppendLine("Benders: None");
                }
                else
                {
                    sb.AppendLine("Benders:");
                    foreach (var bender in fireBenders)
                    {
                        sb.AppendLine("###" + bender.ToString());
                    }
                }
                break;
            case "Earth":
                if (earthBenders.Count == 0)
                {
                    sb.AppendLine("Benders: None");
                }
                else
                {
                    sb.AppendLine("Benders:");
                    foreach (var bender in earthBenders)
                    {
                        sb.AppendLine("###" + bender.ToString());
                    }
                }
                break;
        }
        
        if (this.monuments.Where(m => m.GetType().Name == nationsType + "Monument").Count() == 0)
        {
            sb.AppendLine("Monuments: None");
        }
        else
        {
            sb.AppendLine("Monuments:");
            foreach (var monument in this.monuments.Where(a => a.GetType().Name == nationsType + "Monument"))
            {
                sb.AppendLine("###" + monument.ToString());
            }
        }
        return sb;
    }

    public void IssueWar(string nationsType)
    {
        this.warsSequence.Add(nationsType);

        var AirTotalPower = this.airBenders.Sum(a => a.Power) * (GetMonumentBonus("air") / 100);
        var FireTotalPower = this.fireBenders.Sum(a => a.Power) * (GetMonumentBonus("fire") / 100);
        var WaterTotalPower = this.waterBenders.Sum(a => a.Power) * (GetMonumentBonus("water") / 100);
        var EarthTotalPower = this.earthBenders.Sum(a => a.Power) * (GetMonumentBonus("earth") / 100);

        var nationsWithPower = new Dictionary<string, double>
        {
            ["Air"] = AirTotalPower,
            ["Fire"] = FireTotalPower,
            ["Water"] = WaterTotalPower,
            ["Earth"] = EarthTotalPower
        };

        //double max = Math.Max(Math.Max(AirTotalPower, FireTotalPower), Math.Max(WaterTotalPower, EarthTotalPower));

        GetWinner(nationsWithPower);
    }

    private void GetWinner(Dictionary<string, double> nationsWithPower)
    {
        var maxPower = nationsWithPower.Values.Max();


        if (nationsWithPower["Fire"] ==  maxPower)
        {
            this.waterBenders.Clear();
            this.earthBenders.Clear();
            this.airBenders.Clear();
            List<Monument> leftMonuments = this.monuments.Where(a => a.GetType().Name == "FireMonument").ToList();
            this.monuments.Clear();
            this.monuments = leftMonuments;
        }
        else if (nationsWithPower["Water"] == maxPower)
        {
            this.fireBenders.Clear();
            this.earthBenders.Clear();
            this.airBenders.Clear();
            List<Monument> leftMonuments = this.monuments.Where(a => a.GetType().Name == "WaterMonument").ToList();
            this.monuments.Clear();
            this.monuments = leftMonuments;
        }
        else if (nationsWithPower["Air"] == maxPower)
        {
            this.fireBenders.Clear();
            this.earthBenders.Clear();
            this.waterBenders.Clear();
            List<Monument> leftMonuments = this.monuments.Where(a => a.GetType().Name == "AirMonument").ToList();
            this.monuments.Clear();
            this.monuments = leftMonuments;
        }
        else if (nationsWithPower["Earth"] == maxPower)
        {
            this.fireBenders.Clear();
            this.waterBenders.Clear();
            this.airBenders.Clear();
            List<Monument> leftMonuments = this.monuments.Where(a => a.GetType().Name == "EarthMonument").ToList();
            this.monuments.Clear();
            this.monuments = leftMonuments;
        }
    }

    private double GetMonumentBonus(string type)
    {
        switch (type)
        {
            case "air":
                double airBonus = 0;
                foreach (AirMonument mon in this.monuments.Where(m => m.GetType().Name == "AirMonument"))
                {
                    airBonus += mon.AirAffinity;
                }
                return airBonus;
            case "fire":
                double fireBonus = 0;
                foreach (FireMonument mon in this.monuments.Where(m => m.GetType().Name == "FireMonument"))
                {
                    fireBonus += mon.FireAffinity;
                }
                return fireBonus;
            case "water":
                double waterBonus = 0;
                foreach (WaterMonument mon in this.monuments.Where(m => m.GetType().Name == "WaterMonument"))
                {
                    waterBonus += mon.WaterAffinity;
                }
                return waterBonus;
            case "earth":
                double earthBonus = 0;
                foreach (EarthMonument mon in this.monuments.Where(m => m.GetType().Name == "EarthMonument"))
                {
                    earthBonus += mon.EartAffinity;
                }
                return earthBonus;
            default: return 0.00;
        }
    }

    public string GetWarsRecord()
    {
        var sb = new StringBuilder();

        int position = 0;

        foreach (var war in this.warsSequence)
        {
            sb.AppendLine($"War {++position} issued by {war}");
        }

        return sb.ToString().TrimEnd();
    }

}

