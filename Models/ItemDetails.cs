using System;

namespace HandOver.Client.Models;

public class ItemDetails
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? ImageUrl { get; set; }
    public int CategoryId { get; set; }
    public int ConditionId { get; set; }
    public required string Location { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public string? Description { get; set; }
    public int SellerId { get; set; }
    public DateTime PostedOn { get; set; }
}
