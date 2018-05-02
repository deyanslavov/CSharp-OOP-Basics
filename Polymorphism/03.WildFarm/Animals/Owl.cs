using System;

public class Owl : Bird
{
    public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize) { }

    public override void Eat(Food food)
    {
        this.ProduceSound();
        if (food.GetType().Name == "Meat")
        {
            this.Weight += food.Quantity * 0.25;
            this.FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine(string.Format("Owl does not eat {0}!", food.GetType().Name));
        }
    }

    protected override void ProduceSound()
    {
        Console.WriteLine("Hoot Hoot");
    }
}