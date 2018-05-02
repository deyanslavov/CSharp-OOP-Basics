using System.Collections.Generic;

class Car
{
    private string model;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    private Cargo cargo;

    public Cargo Cargo
    {
        get { return cargo; }
        set { cargo = value; }
    }

    private Engine engine;

    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    private List<Tire> tires;

    public List<Tire> Tires { get; set; }

    public Car()
    {
        this.tires = new List<Tire>(4);
        this.cargo = new Cargo();
        this.engine = new Engine();
    }

    public Car(string model, Cargo cargo, Engine engine):this()
    {
        this.model = model;
        this.cargo = cargo;
        this.engine = engine;
    }
}

