using System;

class Square
{
    public int A { get; set; }

    public Square()
    {

    }

    public Square(int a)
    {
        this.A = a;
    }

    public void Draw(int a)
    {
        Console.WriteLine("|" + new string('-', a) + "|");
        for (int i = 0; i < a-2; i++)
        {
            Console.Write("|");
            Console.Write(new string(' ', a));
            Console.Write("|");
            Console.WriteLine();
        }
        Console.WriteLine("|" + new string('-', a) + "|");
    }
}

