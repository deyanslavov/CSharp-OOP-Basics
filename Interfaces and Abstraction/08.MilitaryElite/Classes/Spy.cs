using System.Text;

public class Spy : Soldier, ISpy
{
    public int CodeNumber { get; set; }

    public Spy(int id, string firstName, string lastName, int codeNumber):
        base(id, firstName, lastName)
    {
        this.CodeNumber = codeNumber;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString())
            .AppendLine($"Code Number: {this.CodeNumber}");
        return sb.ToString().TrimEnd();
    }
}

