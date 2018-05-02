using System;

public class Dog : Mammal
{
    public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion) { }

    public override void Eat(Food food)
    {
        this.ProduceSound();
        if (food.GetType().Name == "Meat")
        {
            this.Weight += food.Quantity * 0.40;
            this.FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine(string.Format("Dog does not eat {0}!", food.GetType().Name));
        }
    }

    protected override void ProduceSound()
    {
        Console.WriteLine("Woof!");
    }
}