﻿public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string author, string title, decimal price):base(author, title, price)
    {
    }

    public override decimal Price
    {
        get
        {
            return this.Price;
        }
        set
        {
            base.Price = value* 1.3m;
        }
        
    }
}

