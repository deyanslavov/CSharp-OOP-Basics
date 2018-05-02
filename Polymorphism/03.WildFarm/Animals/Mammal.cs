public abstract class Mammal : Animal
{
    private string livingRegion;

    public Mammal(string name, double weight, string livingRegion) : base(name, weight)
    {
        this.LivingRegion = livingRegion;
    }

    public string LivingRegion { get { return this.livingRegion; } set { this.livingRegion = value; } }

    public override string ToString()
    {
        return string.Format("{0} [{1}, {2}, {3}, {4}]", this.GetType().Name, this.Name, this.Weight, this.LivingRegion, this.FoodEaten);
    }
}