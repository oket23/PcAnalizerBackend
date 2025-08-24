namespace PcAnalyzer.Models;

public class GPUInfo
{
    public string Name { get; set; }
    public int MinRefreshRate { get; set; }
    public int MaxRefreshRate { get; set; }
    public int CurrentREfreshRate { get; set; }
    public int CurrentHorizontalResolution { get; set; }
    public int CurrentVerticalResolution { get; set; }
    public long MemoryMB { get; set; } 
    public string DriverVersion { get; set; }

    public override string ToString()
    {
        return $"GPU: {Name}\n" +
            $"Current Resolution: {CurrentHorizontalResolution}x{CurrentVerticalResolution}\n" +
            $"Current Refresh Rate: {CurrentREfreshRate} Hz\n" +
            $"Refresh Rate: {MinRefreshRate}-{MaxRefreshRate} Hz\n" +
            $"Memory: {MemoryMB} MB\n" +
            $"Driver Version: {DriverVersion}";
    }
}
