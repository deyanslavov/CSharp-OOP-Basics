using System.Collections.Generic;

public class AddCollection : IAdd
{
    private List<string> collection;

    public AddCollection()
    {
        this.collection = new List<string>();
    }

    public int Add(string item)
    {
        collection.Add(item);
        return collection.Count - 1;
    }
}

