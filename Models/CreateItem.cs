using System;

namespace HandOver.Client.Models;

public class CreateItem
{
    public required string Name { get; set; }
    public int CategoryId { get; set; }
    public int ItemConditionId { get; set; }
    public required string Location { get; set; }
    public int Price { get; set; }
    public string? Description { get; set; }
    public required string ImageUrl { get; set; }
}
