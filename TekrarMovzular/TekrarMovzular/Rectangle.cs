namespace TekrarMovzular;

public class Rectangle
{
    public double Width;
    public double Height;
    public double GetArea()
    {
        return Width* Height;
    }
    public double GetPerimetr()
    {
        return 2 * (Width + Height);
    }
}
