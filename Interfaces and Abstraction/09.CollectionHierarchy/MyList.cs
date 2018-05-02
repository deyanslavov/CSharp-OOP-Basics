using System.Collections.Generic;

public class MyList : IAdd, IRemove, IUsed
{
    private List<string> collection = new List<string>();

    public int Used => collection.Count;

    public int Add(string item)
    {
        collection.Insert(0, item);
        return 0;
    }

    public string Remove()
    {
        string item = collection[0];
        collection.RemoveAt(0);
        return item;
    }
}

