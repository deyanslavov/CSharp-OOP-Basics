using System;

public class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed) { }

    public override void Eat(Food food)
    {
        this.ProduceSound();
        if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Meat")
        {
            this.Weight += food.Quantity * 0.30;
            this.FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine(string.Format("Cat does not eat {0}!", food.GetType().Name));
        }
    }

    protected override void ProduceSound()
    {
        Console.WriteLine("Meow");
    }
}