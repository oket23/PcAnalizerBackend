using Microsoft.Extensions.Logging;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace AnalizerBackend.Services;

public class TelegramBotService
{
    private TelegramBotClient _client;
    private User _bot;
    private static readonly string _botToken = Environment.GetEnvironmentVariable("TELEGRAM_BOT_TOKEN");
    private static readonly string _chatId = Environment.GetEnvironmentVariable("TELEGRAM_CHAT_ID");

    public TelegramBotService()
    {
        _client = new TelegramBotClient(_botToken);
    }

    public async Task SendJsonFileAsync(string json)
    {
        using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json));
        var fileName = $"report-{DateTime.UtcNow:yyyy-MM-dd_HH-mm-ss}.json";

        await _client.SendDocument(_chatId,new InputFileStream(stream,fileName));
    }
}
