namespace RestaurantProjects.Data.Entities;

public class DiningTable
{
    public int Id { get; set; }
    public int RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; } = null!;
    public string TableNumber { get; set; } = null!;
    public int SeatingCapacity { get; set; }
    public bool IsAvailable { get; set; }
    public DateTime? CreatedAt { get; set; } = null!;
}
