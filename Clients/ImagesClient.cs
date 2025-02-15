using System;

namespace HandOver.Client.Clients;

public class ImagesClient(HttpClient httpClient)
{
    public async Task<string[]> GetItemImagesAsync(int id)
        => await httpClient.GetFromJsonAsync<string[]>($"item-images/{id}") ?? [];
}
