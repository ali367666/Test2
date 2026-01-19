namespace RestaurantProjects.Data.Entities;

public class Restaurant
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string City { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public DateTime? CreatedAt { get; set; } = null!;
    }
