using System;
using HandOver.Client.Models;

namespace HandOver.Client.Clients;

public class ItemsConditionsClient(HttpClient httpClient)
{
    private readonly ItemCondition[] _conditions =
    [
        new() {Id = 1, Condition = "New"},
        new() {Id = 2, Condition = "Like new"},
        new() {Id = 3, Condition = "Fairly used"},
        new() {Id = 4, Condition = "Heavily used"},
    ];

    public async Task<ItemCondition[]> GetItemsConditionsAsync()
        => await httpClient.GetFromJsonAsync<ItemCondition[]>("item-conditions")
            ?? [];
    
    public async Task<ItemCondition> GetItemConditionAsync(int id)
        => await httpClient.GetFromJsonAsync<ItemCondition>($"item-conditions/{id}")
            ?? throw new Exception("Could not find item-condition");
}
