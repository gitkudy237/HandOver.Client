using System;

namespace HandOver.Client.Clients;

public class ImagesClient(HttpClient httpClient)
{
    public async Task<string[]> GetAllItemImagesAsync(int id)
        => await httpClient.GetFromJsonAsync<string[]>($"item-images/all/{id}") ?? [];

    public async Task<string> GetSingleItemImageAsync(int id)
        => await httpClient.GetStringAsync($"item-images/single/{id}");
}
