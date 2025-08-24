using Microsoft.AspNetCore.Mvc;
using PcAnalyzer.Models;
using System.Text.Json;

namespace AnalizerBackend.Controllers;

[ApiController]
[Route("system_report")]
public class ReportsController : ControllerBase
{
    [HttpPost]
    public IActionResult PostReport([FromBody] SystemReport report)
    {
        if (report != null)
        {
            Console.WriteLine("1");
            var fileName = $"reports/{DateTime.UtcNow:yyyy-MM-dd_HH-mm-ss}.json";
            Directory.CreateDirectory("reports");
            System.IO.File.WriteAllText(fileName, JsonSerializer.Serialize(report, new JsonSerializerOptions { WriteIndented = true }));

            return Ok(new { message = "Report received successfully" });
        }

        return BadRequest("Invalid report");
    }
}
