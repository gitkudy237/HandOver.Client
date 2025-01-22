using HandOver.Client.Models;

namespace HandOver.Client.Clients;

public class ItemsClient
{
    private readonly List<ItemSummary> _items =
        [

            new() {
                Name = "Yamaha Acoustic Guitar",
                Category = "Music",
                ImageUrl = "Images/guitar.jpg",
                Location = "Yaounde",
                Price = 50_000m,
                Seller = "GeorgeHassan"
            },
            new() {
                Name = "Wooden Chair",
                Category = "Furnitures",
                ImageUrl = "Images/chair.jpg",
                Location = "Yaounde",
                Price = 10_500m,
                Seller = "Afane237"
            }

        ];

    public ItemSummary[] GetItems()
    {
        return [.. _items];
    }
}
