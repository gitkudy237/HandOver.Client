using HandOver.Client.Models;

namespace HandOver.Client.Clients;

public class ItemsClient
{
    private readonly List<ItemSummary> _items =
        [

            new() {
                Id = 1,
                Name = "Yamaha Acoustic Guitar",
                Category = "music",
                ImageUrl = "Images/guitar.jpg",
                Location = "Yaounde",
                Price = 50_000m,
                Seller = "GeorgeHassan"
            },
            new() {
                Id = 2,
                Name = "Wooden Chair",
                Category = "furnitures",
                ImageUrl = "Images/chair.jpg",
                Location = "Yaounde",
                Price = 10_500m,
                Seller = "Afane237"
            },
            new() {
                Id = 3,
                Name = "Dell Laptop",
                Category = "devices",
                ImageUrl = "",
                Location = "Douala",
                Price = 100_000m,
                Seller = "Clovis23"
            }

        ];

    public ItemSummary[] GetItems()
    {
        return [.. _items];
    }

    public List<ItemSummary> GetItems(string category)
    {
        var items = _items.Where(i => i.Category == category).ToList();
        return items;
    }
}
