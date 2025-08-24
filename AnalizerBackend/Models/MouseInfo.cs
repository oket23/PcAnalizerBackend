namespace PcAnalyzer.Models;

public class MouseInfo
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Manufacturer { get; set; }
    public string DeviceID { get; set; }
    public string PNPDeviceID { get; set; }
    public int NumberOfButtons { get; set; }
    public int PointingType { get; set; }
    public string Status { get; set; }

    public string VendorProductId
    {
        get
        {
            if (string.IsNullOrEmpty(PNPDeviceID)) return "Unknown";
            var vid = "VID_UNKNOWN";
            var pid = "PID_UNKNOWN";

            var parts = PNPDeviceID.Split('&');
            foreach (var p in parts)
            {
                if (p.StartsWith("VID_", StringComparison.OrdinalIgnoreCase))
                    vid = p;
                if (p.StartsWith("PID_", StringComparison.OrdinalIgnoreCase))
                    pid = p;
            }

            return $"{vid}_{pid}";
        }
    }

    public string PointingTypeName
    {
        get
        {
            return PointingType switch
            {
                1 => "Other",
                2 => "Mouse",
                3 => "Trackball",
                4 => "Track Point",
                5 => "Glide Point (Touchpad)",
                6 => "Touch Pad",
                7 => "Touch Screen",
                8 => "Optical Sensor Mouse",
                _ => $"Unknown ({PointingType})"
            };
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}\n" +
               $"Description: {Description}\n" +
               $"Manufacturer: {Manufacturer}\n" +
               $"Buttons: {NumberOfButtons}\n" +
               $"Type: {PointingTypeName}\n" +
               $"Status: {Status}\n" +
               $"DeviceID: {DeviceID}\n" +
               $"PNPDeviceID: {PNPDeviceID}";
    }
}
