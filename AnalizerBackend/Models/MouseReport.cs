using System.Text;

namespace PcAnalyzer.Models;

public class MouseReport
{
    public int PhysicalCount { get; set; }
    public int DriverCount { get; set; }
    public List<MouseInfo> Mice { get; set; } = new();


}
