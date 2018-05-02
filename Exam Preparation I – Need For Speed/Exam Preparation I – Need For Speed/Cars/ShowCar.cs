using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ShowCar : Car
{
    private int stars;

    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability, int stars) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.Stars = stars;
    }

    public int Stars
    {
        get { return stars; }
        set { stars = value; }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(base.ToString())
            .AppendLine($"{Stars} *");

        return sb.ToString().TrimEnd();
    }
}

