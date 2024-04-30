using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TasksManager.FrontEnd;
using TasksManager.FrontEnd.Repositories;
using TasksManager.FrontEnd.Repository;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7189") });

builder.Services.AddScoped<IRepository, Repository>();

await builder.Build().RunAsync();
