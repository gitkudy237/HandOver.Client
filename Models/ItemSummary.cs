namespace HandOver.Client.Models;

public class ItemSummary
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Category { get; set; }
    public string? ImageUrl { get; set; }
    public required string Location { get; set; }
    public int Price { get; set; }
    public DateTime PostedOn { get; set; }
    public bool CanBeDelivered { get; set; }
}
