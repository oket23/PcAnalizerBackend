namespace PcAnalyzer.Models;

public class RAMInfo
{
    public double CapacityGB { get; set; }
    public int Speed { get; set; }
    public string Manufacturer { get; set; }
    public string FormFactor { get; set; }
    public string PartNumber { get; set; }
    public string Slot { get; set; }
    public string SerialNumber { get; set; }

    public override string ToString()
    {
        return $"Capacity: {CapacityGB} GB\n" +
               $"Speed: {Speed} MHz\n" +
               $"Manufacturer: {Manufacturer}\n" +
               $"Part Number: {PartNumber}\n" +
               $"Form Factor: {FormFactor}\n" +
               $"Slot: {Slot}\n" +
               $"Serial Number: {SerialNumber}";
    }
}
