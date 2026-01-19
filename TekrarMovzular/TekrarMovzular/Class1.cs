namespace TekrarMovzular;

public class Class1
{
    public string  Brand { get; set; }
    public string Color { get; set; }
    public int Speed { get; set; } = 0;
    public Class1(string brand,string color)
    {
        Brand = brand;
        Color = color;
       
    }
    public void IncreaseSpeed(int value)
    {
        Speed += value;
    }
}
