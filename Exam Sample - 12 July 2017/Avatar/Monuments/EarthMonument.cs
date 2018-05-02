using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EarthMonument : Monument
{
    private int earthAffinity;

    public EarthMonument(string name, int earthAffinity): base(name)
    {
        this.EartAffinity = earthAffinity;
    }

    public int EartAffinity
    {
        get { return earthAffinity; }
        private set { earthAffinity = value; }
    }

    public override string ToString()
    {
        return $"Earth Monument: {this.Name}, Earth Affinity: {earthAffinity}";
    }
}

