using System;

public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed) { }

    public override void Eat(Food food)
    {
        this.ProduceSound();
        if (food.GetType().Name == "Meat")
        {
            this.Weight += food.Quantity;
            this.FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine(string.Format("Tiger does not eat {0}!", food.GetType().Name));
        }
    }

    protected override void ProduceSound()
    {
        Console.WriteLine("ROAR!!!");
    }
}