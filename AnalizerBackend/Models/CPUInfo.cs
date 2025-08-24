namespace PcAnalyzer.Models;

public class CPUInfo
{
    public string CPU { get; set; }
    public string SystemName { get; set; }
    public string SocketDesignation { get; set; }
    public int Cores { get; set; }
    public int Threads { get; set; }
    public int MaxClockSpeed { get; set; }
    public int CurrentClockSpeed { get; set; }
    public int L2CacheSize { get; set; }
    public int L3CacheSize { get; set; }
    public string Description { get; set; }
    public string ProcessorId { get; set; }
    public int Revision { get; set; }
    public bool VirtualizationFirmwareEnabled { get; set; }
    public string WorkTime { get; set; }

    public override string ToString()
    {
        return $"CPU: {CPU}\n" +
            $"SystemName: {SystemName}\n" +
            $"Socket: {SocketDesignation}\n" +
            $"Cores: {Cores}\n" +
            $"Threads: {Threads}\n" +
            $"Max Clock Speed: {MaxClockSpeed} MHz\n" +
            $"CurrentClockSpeed: {CurrentClockSpeed} MHz\n" +
            $"L2Cache: {L2CacheSize} KB\n" +
            $"L3Cache: {L3CacheSize} KB\n" +
            $"Description: {Description}\n" +
            $"ProcessorId: {ProcessorId}\n" +
            $"Revision: {Revision}\n" +
            $"VirtualizationFirmwareEnabled: {VirtualizationFirmwareEnabled}\n" +
            $"WorkTime: {WorkTime}";
    }
}

