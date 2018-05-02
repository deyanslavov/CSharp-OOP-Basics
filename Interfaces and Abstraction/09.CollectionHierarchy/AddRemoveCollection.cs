using System.Collections.Generic;

public class AddRemoveCollection : IAdd, IRemove
{
    private List<string> collection = new List<string>();
    
    public int Add(string item)
    {
        collection.Insert(0, item);
        return 0;
    }

    public string Remove()
    {
        string item = collection[collection.Count - 1];
        collection.RemoveAt(collection.Count - 1);
        return item;
    }
}

