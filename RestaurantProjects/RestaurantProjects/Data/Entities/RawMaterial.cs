namespace RestaurantProjects.Data.Entities;

public class RawMaterial
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int UnitTypeId { get; set; }
    public UnitType UnitType { get; set; } = null!;
    public int ProductCategoryId { get; set; }
    public ProductCategory ProductCategory { get; set; } = null!;

}
