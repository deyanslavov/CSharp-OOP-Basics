namespace _15.Drawing_Tool
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var dt = new DrawingTool();

            var line = Console.ReadLine();

            if (line == "Square")
            {
                var a = int.Parse(Console.ReadLine());
                var square = new Square();
                dt.Square = square;
                dt.Square.Draw(a);

            }
            else
            {
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());
                var rect = new Rectangle();
                dt.Rectangle = rect;
                dt.Rectangle.Draw(a, b);
            }
        }
    }
}
