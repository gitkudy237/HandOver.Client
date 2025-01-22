using HandOver.Client.Models;

namespace HandOver.Client.Clients;

public class ItemsClient
{
    private readonly List<ItemSummary> _articles =
        [

            new() {
                Name = "Yamaha Acoustic Guitar With Nylon Strings",
                ImageUrl = "Images/guitar.jpg",
                Location = "Yaounde",
                Price = 50_000m,
                Seller = "GeorgeHassan"
            },
            new() {
                Name = "Wooden Chair",
                ImageUrl = "Images/chair.jpg",
                Location = "Yaounde",
                Price = 10_500m,
                Seller = "Afane237"
            }

        ];

    public ItemSummary[] GetItems()
    {
        return [.. _articles];
    }
}
