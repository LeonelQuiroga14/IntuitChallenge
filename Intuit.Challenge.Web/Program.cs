using CurrieTechnologies.Razor.SweetAlert2;
using Intuit.Challenge.Web;
using Intuit.Challenge.Web.Utilities;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSweetAlert2();
builder.Services.AddHttpClient(AppConstants.WEB_API_CLIENT, client =>
{
    
    client.BaseAddress = new Uri(AppConstants.WEB_API_CLIENT_URL);
    client.DefaultRequestHeaders.Add("x-api-key", AppConstants.WEB_API_CLIENT_KEY);
});

await builder.Build().RunAsync();
