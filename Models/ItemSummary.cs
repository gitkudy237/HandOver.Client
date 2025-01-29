namespace HandOver.Client.Models;

public class ItemSummary
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Category { get; set; }
    public string? ImageUrl { get; set; }
    public required string Location { get; set; }
    public decimal Price { get; set; }
    public required string Seller { get; set; }
}
