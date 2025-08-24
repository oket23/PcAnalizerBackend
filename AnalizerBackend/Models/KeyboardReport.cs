using System.Text;

namespace PcAnalyzer.Models;

public class KeyboardReport
{
    public int PhysicalCount { get; set; }
    public int DriverCount { get; set; }
    public List<KeyboardInfo> Keyboards { get; set; } = new();
}
