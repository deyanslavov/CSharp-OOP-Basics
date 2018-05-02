using System;

public class Hen : Bird
{
    public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize) { }

    public override void Eat(Food food)
    {
        this.ProduceSound();
        this.Weight += food.Quantity * 0.35;
        this.FoodEaten += food.Quantity;
    }

    protected override void ProduceSound()
    {
        Console.WriteLine("Cluck");
    }
}