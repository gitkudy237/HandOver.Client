using HandOver.Client.Models;

namespace HandOver.Client.Clients;

public class CategoriesClient(HttpClient httpClient)
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

    public async Task<Category[]> GetCategoriesAsync()
        => await httpClient.GetFromJsonAsync<Category[]>("categories") ?? [];

    public async Task<Category> GetCategoryAsync(int id)
        => await httpClient.GetFromJsonAsync<Category>($"categories/{id}") 
            ?? throw new Exception("Could not find Category");
    
}
