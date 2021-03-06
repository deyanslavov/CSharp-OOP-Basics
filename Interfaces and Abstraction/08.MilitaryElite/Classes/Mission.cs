﻿public class Mission
{
    private string CodeName { get; set; }
    public string State { get; set; }

    public Mission(string codeName, string state)
    {
        this.CodeName = codeName;
        this.State = state;
    }

    public override string ToString()
    {
        return $"Code Name: {this.CodeName} State: {this.State}";
    }
}

