using HandOver.Client.Models;

namespace HandOver.Client.Clients;

public class ItemsClient(HttpClient httpClient)
{
    private readonly List<ItemSummary> _itemsSummaries =
        [

            // new() {
            //     Id = 1,
            //     Name = "Yamaha Acoustic Guitar",
            //     Category = "music",
            //     ImageUrl = "Images/guitar.jpg",
            //     Location = "Yaounde",
            //     Price = 50_000,
            //     Seller = "GeorgeHassan"
            // },
            // new() {
            //     Id = 2,
            //     Name = "Wooden Chair",
            //     Category = "furnitures",
            //     ImageUrl = "Images/chair.jpg",
            //     Location = "Yaounde",
            //     Price = 10_500,
            //     Seller = "Afane237"
            // },
            // new() {
            //     Id = 3,
            //     Name = "Dell Laptop",
            //     Category = "devices",
            //     ImageUrl = "Images/laptop.jpg",
            //     Location = "Douala",
            //     Price = 100_000,
            //     Seller = "Clovis23"
            // }

        ];

    private readonly List<ItemDetails> _itemsDetails = new();

    public async Task<ItemSummary[]> GetItemsAsync()
        => await httpClient.GetFromJsonAsync<ItemSummary[]>("items/summary") ?? [];

    public async Task<ItemDetails> GetItemAsync(int id)
        => await httpClient.GetFromJsonAsync<ItemDetails>($"/items/{id}")
            ?? throw new Exception("Could not find item");
    
    public async Task<ItemSummary[]> GetItemByCategoryAsync(int id)
        => await httpClient.GetFromJsonAsync<ItemSummary[]>($"items/category/{id}") ?? [];

    public async Task AddItemAsync(CreateItem item)
        => await httpClient.PostAsJsonAsync("items", item);

    public async Task UpdateItemAsync(int id, CreateItem updatedItem)
        => await httpClient.PutAsJsonAsync($"items/{id}", updatedItem);
    
    public async Task DeletItemAsync(int id)
        => await httpClient.DeleteAsync($"items/{id}");
}
