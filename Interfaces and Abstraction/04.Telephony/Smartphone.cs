using System;
using System.Linq;

public class Smartphone : IBrowsable, ICallable
{
    public Smartphone()
    {

    }

    public void Browse(string text)
    {
        if (text.Any(a => char.IsDigit(a)))
        {
            Console.WriteLine("Invalid URL!");
        }
        else
        {
            Console.WriteLine($"Browsing: {text}!");
        }
    }

    public void Call(string number)
    {
        if (number.Any(a => !char.IsDigit(a)))
        {
            Console.WriteLine("Invalid number!");
        }
        else
        {
            Console.WriteLine($"Calling... {number}");
        }
    }
}

