using System.Globalization;

namespace PcAnalyzer.Models;

public class KeyboardInfo
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string DeviceID { get; set; }
    public string PNPDeviceID { get; set; }
    public string Layout { get; set; }
    public int NumberOfFunctionKeys { get; set; }
    public string Status { get; set; }

    public string VendorProductId
    {
        get
        {
            if (string.IsNullOrEmpty(PNPDeviceID)) return "Unknown";
            var parts = PNPDeviceID.Split('&');
            var vid = parts.FirstOrDefault(p => p.StartsWith("VID_", StringComparison.OrdinalIgnoreCase));
            var pid = parts.FirstOrDefault(p => p.StartsWith("PID_", StringComparison.OrdinalIgnoreCase));
            return $"{vid}_{pid}";
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}\n" +
               $"Description: {Description}\n" +
               $"Function Keys: {NumberOfFunctionKeys}\n" +
               $"Status: {Status}\n" +
               $"DeviceID: {DeviceID}\n" +
               $"PNPDeviceID: {PNPDeviceID}";
    }
}
