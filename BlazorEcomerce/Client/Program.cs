global using BlazorEcomerce.Shared;
global using System.Net.Http.Json;
global using BlazorEcomerce.Client.Services.ProductService;
global using BlazorEcomerce.Client.Services.CategoryService;
global using BlazorEcomerce.Client.Services.CartService;
global using BlazorEcomerce.Client.Services.AuthService;
global using Microsoft.AspNetCore.Components.Authorization;

using BlazorEcomerce.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CastomAuthStateProvider>();


await builder.Build().RunAsync();
