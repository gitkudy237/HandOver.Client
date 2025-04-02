using HandOver.Client.Clients;
using HandOver.Client.Components;
using MudBlazor.Services;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var handOverApiUrl = builder.Configuration["handOverApiUrl"] ?? 
    throw new Exception("HandOverApiUrl is not set");

builder.Services.AddHttpClient<ItemsClient>(
    client => client.BaseAddress = new Uri(handOverApiUrl));
builder.Services.AddHttpClient<CategoriesClient>(
    client => client.BaseAddress = new Uri(handOverApiUrl));
builder.Services.AddHttpClient<ItemsConditionsClient>(
    client => client.BaseAddress = new Uri(handOverApiUrl));
builder.Services.AddHttpClient<ImagesClient>(
    client => client.BaseAddress = new Uri(handOverApiUrl));
builder.Services.AddHttpClient<AnnouncementsClient>(
    client => client.BaseAddress = new Uri(handOverApiUrl));


builder.Services.AddSingleton<UsersClient>();

builder.Services.AddRadzenComponents();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
