public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private Point topLeft;

    public Rectangle()
    {
    }

    public string Id
    {
        get { return this.id; }
        set { id = value; }
    }
    
    public double Width
    {
        get { return this.width; }
        set { width = value; }
    }
    
    public double Height
    {
        get { return this.height; }
        set { height = value; }
    }
    
    public Point TopLeft
    {
        get { return this.topLeft; }
        set { topLeft = value; }
    }
    
    public bool IntersectsWith(Rectangle rectangle)
    {
        return rectangle.topLeft.X + rectangle.width >= this.topLeft.X &&
                rectangle.topLeft.X <= this.topLeft.X + this.width &&
                rectangle.topLeft.Y >= this.topLeft.Y - this.height &&
                rectangle.topLeft.Y - rectangle.height <= this.topLeft.Y;
    }
}