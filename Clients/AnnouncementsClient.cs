using System;
using HandOver.Client.Components.Pages;
using HandOver.Client.Models;

namespace HandOver.Client.Clients;

public class AnnouncementsClient(HttpClient httpClient)
{
    public async Task<AnnouncementSummary[]> GetAnnouncementsAsync()
        => await httpClient.GetFromJsonAsync<AnnouncementSummary[]>("announcements") ?? [];
    
    public async Task<AnnouncementSummary?> GetAnnouncementByIdAsync(int id)
        => await httpClient.GetFromJsonAsync<AnnouncementSummary>($"announcements/{id}");
    
    public async Task AddAnnouncementAsync(CreateItemRequest announcement)
        => await httpClient.PostAsJsonAsync("announcements", announcement);

}
