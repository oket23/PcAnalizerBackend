using AnalizerBackend.Services;

namespace AnalizerBackend;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddSingleton<TelegramBotService>();

        var app = builder.Build();

        app.UseExceptionHandler("/error");

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseAuthorization();

        app.MapControllers();

        var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
        app.Urls.Add($"http://*:{port}");

        app.Run();
    }
}
