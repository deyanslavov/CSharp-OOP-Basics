class DrawingTool
{
    public DrawingTool()
    {

    }
    public DrawingTool(Rectangle rectangle)
    {
        this.Rectangle = rectangle;
    }
    public DrawingTool(Square square)
    {
        this.Square = square;
    }

    public Rectangle Rectangle { get; set; }

    public Square Square { get; set; }
}

