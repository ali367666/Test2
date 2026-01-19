namespace RestaurantProjects.Data.Entities;

public class Reservation
{
    public int Id { get; set; }
    public int RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; } = null!;
    public int DiningTableId { get; set; }
    public DiningTable DiningTable { get; set; } = null!;
    public string CustomerName { get; set; } = null!;
    public string CustomerContact { get; set; } = null!;
    public DateTime ReservationTime { get; set; }
    public int NumberOfGuests { get; set; }

}
