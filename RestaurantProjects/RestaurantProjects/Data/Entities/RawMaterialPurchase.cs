namespace RestaurantProjects.Data.Entities;

public class RawMaterialPurchase
{
    public int Id { get; set; }
    public int RawMaterialId { get; set; }
    public RawMaterial RawMaterial { get; set; } = null!;
    public DateTime PurchaseDate { get; set; }
    public decimal Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
