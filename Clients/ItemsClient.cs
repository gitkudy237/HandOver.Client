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
                Price = 50_000,
                Seller = "GeorgeHassan"
            },
            new() {
                Id = 2,
                Name = "Wooden Chair",
                Category = "furnitures",
                ImageUrl = "Images/chair.jpg",
                Location = "Yaounde",
                Price = 10_500,
                Seller = "Afane237"
            },
            new() {
                Id = 3,
                Name = "Dell Laptop",
                Category = "devices",
                ImageUrl = "",
                Location = "Douala",
                Price = 100_000,
                Seller = "Clovis23"
            }

        ];

    private readonly List<User> _users = new UsersClient().GetUsers();
    private readonly Category[] _categories = new CategoriesClient().GetCategories();

    public ItemSummary[] GetItems()
    {
        return [.. _items];
    }

    public List<ItemSummary> GetItems(string category)
    {
        var items = _items.Where(i => i.Category == category).ToList();
        return items;
    }

    public void AddItem(ItemDetails item)
    {
        var seller = _users.First(u => u.Id == item.SellerId);
        var category = _categories.First(c => c.Id == item.CategoryId);
        var itemSummary = new ItemSummary
        {
            Id = _items.Count + 1,
            Name = item.Name,
            Category = category.Name,
            ImageUrl = item.ImageUrl,
            Location = item.Location,
            Price = item.Price,
            Seller = seller.UserName,
        };

        _items.Add(itemSummary);
    }
}
