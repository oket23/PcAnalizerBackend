namespace PcAnalyzer.Models;

public class MotherboardInfo
{
    public string Manufacturer { get; set; }
    public string Product { get; set; }
    public string SerialNumber { get; set; }
    public string Version { get; set; }

    public override string ToString()
    {
        return $"Motherboard: {Product}\n" +
            $"Manufacturer: {Manufacturer}\n" +
            $"Serial Number: {SerialNumber}\n" +
            $"Version: {Version}";
    }
}
