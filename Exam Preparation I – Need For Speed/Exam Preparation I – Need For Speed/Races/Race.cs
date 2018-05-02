using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private List<Car> participans;

    protected Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participans = new List<Car>();
        this.isClosed = false;
    }

    public bool isClosed { get; set; }

    public int Length
    {
        get { return length; }
        protected set { length = value; }
    }
    
    public string Route
    {
        get { return route; }
        protected set { route = value; }
    }
    
    public int PrizePool
    {
        get { return prizePool; }
        protected set { prizePool = value; }
    }
    
    public List<Car> Participans
    {
        get { return participans; }
        set { participans = value; }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{Route} - {Length}");

        return sb.ToString().TrimEnd();
    }
}

