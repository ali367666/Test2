namespace TekrarMovzular;

public class StudentTest
{
    public string Name {  get; set; }
    private int age;
    public int Age
    {
        get { return age; } 
        set { if (value > 0) 
            {
                age=value;
            } 
        }
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Name-{Name};Age-{Age}");
    }
}
