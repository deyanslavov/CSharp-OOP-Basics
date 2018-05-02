using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> products = new List<Product>();

    public List<Product> Products
    {
        get { return products; }
        set { products = value; }
    }

    public Person()
    {
        
    }

    public Person(string name)
    {
        this.Name = name;
    }

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
    }

    public string Name
    {
        get { return name; }
        set
        {
            Validation.ValidateName(value);
            name = value;
        }
    }

    public decimal Money
    {
        get { return money; }
        set
        {
            Validation.ValidateMoney(value);
            money = value;
        }
    }

    public void BuyProduct(Product product)
    {
        if (this.Money >= product.Price)
        {
            this.Products.Add(product);
            this.Money -= product.Price;
            Console.WriteLine($"{this.Name} bought {product.Name}");
        }
        else
        {
            Console.WriteLine($"{this.Name} can't afford {product.Name}");
        }
    }
    public override string ToString()
    {
        if (this.Products.Count == 0)
        {
            return $"{this.Name} - Nothing bought";
        }
        else
        {
            return $"{this.Name} - {string.Join(", ", this.Products)}";
        }
    }
}

