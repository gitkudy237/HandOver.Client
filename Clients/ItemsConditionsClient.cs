using System;
using HandOver.Client.Models;

namespace HandOver.Client.Clients;

public class ItemsConditionsClient
{
    private readonly ItemCondition[] _conditions =
    [
        new() {Id = 1, Condition = "New"},
        new() {Id = 2, Condition = "Like new"},
        new() {Id = 3, Condition = "Fairly used"},
        new() {Id = 4, Condition = "Heavily used"},
    ];

    public ItemCondition[] GetItemsConditions()
        => _conditions;
    
    public ItemCondition? GetItemCondition(int id)
        => _conditions.FirstOrDefault(c => c.Id == id);
}
