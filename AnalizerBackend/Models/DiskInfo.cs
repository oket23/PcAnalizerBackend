
namespace PcAnalyzer.Models;

public class DiskInfo
{
    public string Model { get; set; }
    public string SerialNumber { get; set; }
    public string FirmwareRevision { get; set; }
    public string InterfaceType { get; set; }
    public long Size { get; set; }
    public int Partitions { get; set; }
    public string Status { get; set; }
    public string DeviceID { get; set; }
    public string PNPDeviceID { get; set; }

    public override string ToString()
    {
        return $"Disk Model: {Model}\n" +
               $"Size: {Size / (1024 * 1024 * 1024)} GB\n" +
               $"Interface: {InterfaceType}\n" +
               $"Status: {Status}\n" +
               $"Partitions: {Partitions}\n" +
               $"Firmware: {FirmwareRevision}\n" +
               $"Serial Number: {SerialNumber}\n" +
               $"DeviceID: {DeviceID}\n" +
               $"PNPDeviceID: {PNPDeviceID}";
    }
}