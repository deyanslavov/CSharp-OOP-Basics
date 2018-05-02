﻿using System.Text;

public class Seat : ICar
{
    public string Model { get; set; }

    public string Color { get; set; }

    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {this.GetType()} {this.Model}")
            .AppendLine(this.Start())
            .AppendLine(this.Stop());

        return sb.ToString().TrimEnd();
    }
}

