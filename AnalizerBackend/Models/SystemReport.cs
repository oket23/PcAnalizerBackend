using PcAnalyzer.Modelsp;

namespace PcAnalyzer.Models;

public class SystemReport
{
    public CPUReport CPU { get; set; }
    public GPUReport GPU { get; set; }
    public RAMReport RAM { get; set; }
    public DiskReport Disks { get; set; }
    public KeyboardReport Keyboard { get; set; }
    public MotherboardReport Motherboard { get; set; }
    public MouseReport Mouse { get; set; }
    public OSReport OS { get; set; }
    public StartupReport Startup { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
