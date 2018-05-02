using System.Collections.Generic;

public class Food
{
    private Dictionary<string, int> foodValues = new Dictionary<string, int>()
    {
        ["cram"] = 2,
        ["lembas"] = 3,
        ["apple"] = 1,
        ["melon"] = 1,
        ["honeycake"] = 5,
        ["mushrooms"] = -10,
    };

    public Food(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public int GetPoints(string foodName)
    {
        int result;

        if (foodValues.ContainsKey(foodName.ToLower()))
        {
            result = foodValues[foodName.ToLower()];
        }
        else
        {
            result = -1;
        }
        return result;
    }
}

