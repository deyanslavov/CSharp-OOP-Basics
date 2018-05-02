using System;

class Rectangle
{
    public Rectangle()
    {

    }

    public Rectangle(int a, int b)
    {
        this.A = a;
        this.B = b;
    }

    public int A { get; set; }

    public int B { get; set; }

    public void Draw(int a, int b)
    {
        Console.WriteLine("|" + new string('-', a) + "|");
        for (int i = 0; i < b- 2; i++)
        {
            Console.Write("|");
            Console.Write(new string(' ', a));
            Console.Write("|");
            Console.WriteLine();
        }
        Console.WriteLine("|" + new string('-', a) + "|");
    }
}

