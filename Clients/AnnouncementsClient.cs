using System;
using HandOver.Client.Components.Pages;
using HandOver.Client.Models;

namespace HandOver.Client.Clients;

public class AnnouncementsClient(HttpClient httpClient)
{
    public async Task AddAnnouncementAsync(CreateItemRequest announcement)
        => await httpClient.PostAsJsonAsync("announcements", announcement);
}
