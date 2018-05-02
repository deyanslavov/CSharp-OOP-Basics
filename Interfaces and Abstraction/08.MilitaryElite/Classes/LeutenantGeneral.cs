using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public HashSet<Private> Privates { get; set; }

    public LeutenantGeneral(int id, string firstName, string lastName, double salary):
        base(id, firstName, lastName, salary)
    {
        this.Privates = new HashSet<Private>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString())
            .AppendLine("Privates:");

        foreach (var p in this.Privates)
        {
            sb.AppendLine("  " +p.ToString());
        }
        return sb.ToString().TrimEnd();
    }
}

