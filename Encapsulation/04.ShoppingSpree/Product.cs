public class Product
{
    private string name;
    private decimal price;

    public Product()
    {

    }

    public Product(string name)
    {
        this.Name = name;
    }

    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            Validation.ValidateMoney(value);
            price = value;
        }
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

    public override string ToString()
    {
        return $"{this.Name}";
    }
}

