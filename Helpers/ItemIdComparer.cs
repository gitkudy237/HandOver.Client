using System;
using System.Collections;
using HandOver.Client.Models;

namespace HandOver.Client.Helpers;

public class ItemIdComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is ItemSummary item1 && y is ItemSummary item2)
            return -(item1.Id.CompareTo(item2.Id));
        
        throw new ArgumentException("Argument is not an item");
    }
}
