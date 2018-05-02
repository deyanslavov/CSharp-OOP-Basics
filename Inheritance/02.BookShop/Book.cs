using System;

public class Book
{
    private string title;
    private string author;
    private decimal price;

    public Book()
    {

    }

    public Book(string author, string title, decimal price):this()
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public string Title
    {
        get { return title; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }

    public string Author
    {
        get { return author; }
        set
        {
            if (value.Split().Length > 1)
            {
                var secondName = value.Split()[1];
                if (char.IsDigit(secondName[0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
            }
            author = value;
        }
    }

    public virtual decimal Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            price = value;
        }
    }

    public override string ToString()
    {
        return $"Type: {this.GetType().Name}\nTitle: {this.title}\nAuthor: {this.author}\nPrice: {this.price:f2}".Trim();
    }
}

