public abstract class Animal
{
    private string name;
    private double weight;
    private int foodEaten;

    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
    }

    public string Name { get { return this.name; } protected set { this.name = value; } }
    public double Weight { get { return this.weight; } protected set { this.weight = value; } }
    public int FoodEaten { get { return this.foodEaten; } protected set { this.foodEaten = value; } }

    protected abstract void ProduceSound();
    public abstract void Eat(Food food);
}