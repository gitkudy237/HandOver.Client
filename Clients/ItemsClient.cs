using HandOver.Client.Models;

namespace HandOver.Client.Clients;

public class ItemsClient
{
    private readonly List<ItemSummary> _itemsSummaries =
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
                ImageUrl = "Images/laptop.jpg",
                Location = "Douala",
                Price = 100_000,
                Seller = "Clovis23"
            }

        ];

    private readonly List<ItemDetails> _itemsDetails = new();

    private readonly List<User> _users = new UsersClient().GetUsers();
    private readonly Category[] _categories = new CategoriesClient().GetCategories();

    public ItemSummary[] GetItems()
    {
        return [.. _itemsSummaries];
    }

    public List<ItemSummary> GetItems(string? category)
    {
        ArgumentNullException.ThrowIfNull(category);
        var items = _itemsSummaries.Where(i => i.Category == category).ToList();
        return items;
    }

    public ItemDetails? GetItemDetails(int id)
        => _itemsDetails.FirstOrDefault(i => i.Id == id);

    public List<ItemSummary> GetItems(User user)
        => _itemsSummaries.Where(i => i.Seller.Equals(user.UserName, StringComparison.CurrentCultureIgnoreCase))
                .ToList();

    public void AddItem(ItemDetails item)
    {
        item.Id = _itemsSummaries.Count + 1;
        _itemsSummaries.Add(ToItemSummary(item));
        _itemsDetails.Add(item);
    }

    public ItemSummary ToItemSummary(ItemDetails item)
    {
        ArgumentNullException.ThrowIfNull(item);

        var seller = _users.First(u => u.Id == item.SellerId);
        var category = _categories.First(c => c.Id == item.CategoryId);

        return new ItemSummary
        {
            Id = item.Id,
            Name = item.Name,
            Category = category.Name,
            ImageUrl = item.ImageUrl,
            Location = item.Location,
            Price = item.Price,
            Seller = seller.UserName,
        };
    }

    public void UpdateItem(ItemDetails item)
    {
        var itemDetails = _itemsDetails.FirstOrDefault(i => i.Id == item.Id);
        ArgumentNullException.ThrowIfNull(itemDetails);
        var detailsIndex = _itemsDetails.IndexOf(itemDetails);

        var itemSummary = _itemsSummaries.FirstOrDefault(i => i.Id == item.Id);
        ArgumentNullException.ThrowIfNull(itemSummary);
        var summaryIndex = _itemsSummaries.IndexOf(itemSummary);

        _itemsDetails[detailsIndex] = item;
        _itemsSummaries[summaryIndex] = ToItemSummary(item);
    }

    public void DeleteItem(int id)
    {
        var item = GetItemDetails(id);
        ArgumentNullException.ThrowIfNull(item);

        _itemsSummaries.RemoveAll(i => i.Id == id);
        _itemsDetails.RemoveAll(i => i.Id == id);
    }
}
