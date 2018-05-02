using System;
using System.Collections.Generic;

public class RandomList : List<string>
{
    private Random r = new Random();

    public string RandomString()
    {
        int index = r.Next();
        var result = this[index];
        this.RemoveAt(index);
        return result;
    }
}

