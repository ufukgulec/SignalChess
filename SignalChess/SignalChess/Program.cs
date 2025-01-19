using Microsoft.AspNetCore.ResponseCompression;
using MudBlazor.Services;
using SignalChess.Client.Constants;
using SignalChess.Components;
using SignalChess.Hubs;

namespace SignalChess;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var chessHubUrl = SignalRConstants.Url;
        if (string.IsNullOrEmpty(chessHubUrl))
        {
            throw new InvalidOperationException("ChessHub URL configuration is missing or invalid.");
        }
        // Add MudBlazor services
        builder.Services.AddMudServices();

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents()
            .AddInteractiveWebAssemblyComponents();

        builder.Services.AddSignalR().AddHubOptions<ChessHubs>(options =>
        {
            // Detaylý hata raporlama özelliðini aktif et
            options.EnableDetailedErrors = true;
        }); ;

        builder.Services.AddResponseCompression(opts =>
        {
            opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                ["application/octet-stream"]);
        });

        var app = builder.Build();

        app.UseResponseCompression();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseWebAssemblyDebugging();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode()
            .AddInteractiveWebAssemblyRenderMode()
            .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);


        app.MapHub<ChessHubs>(chessHubUrl);

        app.Run();
    }
}
