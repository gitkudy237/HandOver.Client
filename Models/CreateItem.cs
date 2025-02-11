using System;

namespace HandOver.Client.Models;

public class CreateItem
{
    public string? Name { get; set; }
    public int CategoryId { get; set; }
    public int ItemConditionId { get; set; }
    public string? Location { get; set; }
    public int Price { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
}
