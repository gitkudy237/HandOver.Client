using System;
using System.ComponentModel.DataAnnotations;

namespace HandOver.Client.Models;

public class CreateItem
{
    [Required(ErrorMessage = "Item is required")]
    [StringLength(30, ErrorMessage = "Name should be at most 30 characters")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Please select a category")]
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "Item condition is required")]
    public int ItemConditionId { get; set; }

    [Required][StringLength(20)]
    public string? Location { get; set; }

    [Required][Range(500, 1_000_000)]
    public int Price { get; set; }
    public string? Description { get; set; }
    public List<ImageFile>? Images { get; set; }
    public ImageFile? ProofOfSale { get; set; }
}
