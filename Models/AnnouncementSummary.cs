namespace HandOver.Client.Models;

public class AnnouncementSummary
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; }
    public string? ImageUrl { get; set; }
    public string? Location { get; set; }
    public string? Description { get; set; }
    public int MinPrice { get; set; }
    public int MaxPrice { get; set; }
}
