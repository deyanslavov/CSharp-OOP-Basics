class Cat
{
    public Cat()
    {

    }

    public Cat(string name, string breed, double characteristic)
    {
        this.Name = name;
        this.Breed = breed;
        this.Characteristic = characteristic;
    }

    public string Name { get; set; }

    public string Breed { get; set; }

    public double Characteristic { get; set; }

    public override string ToString()
    {
        if (this.Breed == "Cymric")
        {
            return this.Breed + " " + this.Name + " " + string.Format("{0:0.00}", this.Characteristic);
        }
        return this.Breed + " " + this.Name + " " + this.Characteristic;
    }
}

