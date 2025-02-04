using HandOver.Client.Models;

namespace HandOver.Client.Clients;

public class CategoriesClient
{
    private readonly Category[] _categories =
    {
        new() {Id = 1, Name = "furnitures"},
        new() {Id = 2, Name = "vehicles"},
        new() {Id = 3, Name = "devices"},
        new() {Id = 4, Name = "entertainment"},
        new() {Id = 5, Name = "clothing"},
        new() {Id = 6, Name = "sports"},
        new() {Id = 7, Name = "music"},
        new() {Id = 8, Name = "toys"},
        new() {Id = 9, Name = "real-estate"},
    };

    public Category[] GetCategories()
    {
        return [.. _categories];
    }

    public Category? GetCategory(int id)
        => _categories.FirstOrDefault(c => c.Id == id);

    
}
