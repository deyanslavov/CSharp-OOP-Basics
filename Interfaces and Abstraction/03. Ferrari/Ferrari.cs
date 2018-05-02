public class Ferrari : IDrivable
{
    public string Driver { get; set; }
    public string Model => "488-Spider";

    public Ferrari(string driver)
    {
        this.Driver = driver;
    }

    public string Brakes()
    {
        return "Brakes!";
    }

    public string PushGas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{Brakes()}/{PushGas()}/{this.Driver}";
    }
}

