using AnalizerBackend.Services;
using Microsoft.AspNetCore.Mvc;
using PcAnalyzer.Models;
using System.Text.Json;

namespace AnalizerBackend.Controllers;

[ApiController]
[Route("system_report")]
public class ReportsController : ControllerBase
{
    private TelegramBotService _telegram;
    public ReportsController(TelegramBotService telegram)
    {
        _telegram = telegram;
    }

    [HttpPost]
    public async Task<IActionResult> PostReportAsync([FromBody] SystemReport report)
    {
        if (report != null)
        {
            Console.WriteLine("1");

            var json = JsonSerializer.Serialize(report, new JsonSerializerOptions { WriteIndented = true });
            await _telegram.SendJsonFileAsync(json);

            return Ok(new { message = "Report received successfully" });
        }

        return BadRequest("Invalid report");
    }
}
