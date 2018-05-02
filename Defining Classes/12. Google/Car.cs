public class Car
{
    private string model;
    private int speed;

    public Car()
    {
    }

    public Car(string model, int speed)
    {
        this.model = model;
        this.speed = speed;
    }
    
    public string Model
    {
        get { return this.model; }
        set { model = value; }
    }
    
    public int Speed
    {
        get { return this.speed; }
        set { speed = value; }
    }
    
    public override string ToString()
    {
        return this.model + " " + this.speed;
    }
}
