using System;

public class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion) { }

    public override void Eat(Food food)
    {
        this.ProduceSound();
        if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit")
        {
            this.Weight += food.Quantity * 0.10;
            this.FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine(string.Format("Mouse does not eat {0}!", food.GetType().Name));
        }
    }

    protected override void ProduceSound()
    {
        Console.WriteLine("Squeak");
    }
}