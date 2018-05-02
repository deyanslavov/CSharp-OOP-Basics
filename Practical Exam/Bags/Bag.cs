using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Bag
{
    protected Bag(int capacity)
    {
        this.Capacity = capacity;
        this.Items = new List<Item>();
    }

    public IReadOnlyCollection<Item> Items { get; }

    public int Load => this.Items.Sum(i => i.Weight);

    public int Capacity { get; } = 100;

    public void AddItem(Item item)
    {
        if (this.Load + item.Weight > this.Capacity)
        {
            throw new InvalidOperationException(Messages.BagFull);
        }

        this.Items.ToList().Add(item);
    }

    public Item GetItem(string name)
    {
        if (this.Items.Count == 0)
        {
            throw new InvalidOperationException(Messages.BagEmpty);
        }
        if (!this.Items.Any(i => i.GetType().Name == name))
        {
            throw new ArgumentException(string.Format(Messages.ItemNotFound, name));
        }
        Item item = this.Items.First(i => i.GetType().Name == name);
        this.Items.ToList().Remove(item);
        return item;
    }
}
