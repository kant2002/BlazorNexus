using BlazorNexsus.SampleProject;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorNexsus.Navigation;
using BlazorNexsus.SampleProject.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
builder.Services.AddBlazorNexusNavigation<Routes>(
    pagePostfixCheck: true,
    checkUnusedKeys: true);

await builder.Build().RunAsync();