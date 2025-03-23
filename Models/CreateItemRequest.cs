using System;
using System.ComponentModel.DataAnnotations;

namespace HandOver.Client.Models;

public class CreateItemRequest
{
    [Required][StringLength(30)]
    public string? Name { get; set; }
    public int? CategoryId { get; set; }
    public string? Description { get; set; }
    public ImageFile? Image { get; set; }

    [Required][StringLength(20)]
    public string? Location { get; set; }

    [Required][StringLength(9)]
    public string? UserContact { get; set; }

    [Range(500, 999_999)]
    public int MinPrice { get; set; }
    
    [Range(501, 1_000_000)]
    public int MaxPrice { get; set; }
}
