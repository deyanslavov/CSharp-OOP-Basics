using System.Collections.Generic;

public class StackOfStrings
{
    private List<string> data = new List<string>();

    public void Push(string item)
    {
        data.Add(item);
    }

    public string Pop()
    {
        int index = data.Count - 1;
        string result = data[index];
        data.RemoveAt(index);
        return result;
    }

    public string Peek()
    {
        return data[data.Count - 1];
    }

    public bool IsEmpty()
    {
        return data.Count == 0;
    }
}

