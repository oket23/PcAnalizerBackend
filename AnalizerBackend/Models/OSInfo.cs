using System.Globalization;

namespace PcAnalyzer.Models;

public class OSInfo
{
    public string Caption { get; set; }
    public string Version { get; set; }
    public string BuildNumber { get; set; }
    public string OSArchitecture { get; set; }
    public string Manufacturer { get; set; }
    public string SerialNumber { get; set; }
    public string RegisteredUser { get; set; }

    public DateTime? InstallDate { get; set; }
    public DateTime? LastBootUpTime { get; set; }

    public long FreePhysicalMemoryKB { get; set; }
    public long TotalVisibleMemoryKB { get; set; }
    public int NumberOfUsers { get; set; }
    public string SystemDrive { get; set; }
    public string WindowsDirectory { get; set; }
    public string Status { get; set; }

    public string Locale { get; set; }
    public int CurrentTimeZone { get; set; }

    public TimeSpan? Uptime => LastBootUpTime.HasValue ? DateTime.Now - LastBootUpTime.Value : null;

    public string LocaleName
    {
        get
        {
            try
            {
                if (string.IsNullOrEmpty(Locale)) return "Unknown";
                int lcid = int.Parse(Locale, NumberStyles.HexNumber);
                var culture = new CultureInfo(lcid);
                return $"{culture.EnglishName} ({Locale})";
            }
            catch
            {
                return $"Unknown ({Locale})";
            }
        }
    }
    public string TimeZoneName
    {
        get
        {
            try
            {
                var offset = TimeSpan.FromMinutes(CurrentTimeZone);
                return $"UTC{offset.Hours:+00;-00;+00}:{offset.Minutes:00}";
            }
            catch
            {
                return $"UTC{CurrentTimeZone / 60:+00;-00;+00}:00";
            }
        }
    }

    public override string ToString()
    {
        return $"Operating System: {Caption}\n" +
               $"Version: {Version} (Build {BuildNumber})\n" +
               $"Architecture: {OSArchitecture}\n" +
               $"Manufacturer: {Manufacturer}\n" +
               $"Install Date: {InstallDate:dd.MM.yyyy HH:mm:ss}\n" +
               $"Last Boot Time: {LastBootUpTime:dd.MM.yyyy HH:mm:ss}\n" +
               $"Uptime: {Uptime?.Days}d {Uptime?.Hours}h {Uptime?.Minutes}m\n" +
               $"Registered User: {RegisteredUser}\n" +
               $"Users: {NumberOfUsers}\n" +
               $"Memory: {FreePhysicalMemoryKB / 1024} MB free / {TotalVisibleMemoryKB / 1024} MB total\n" +
               $"System Drive: {SystemDrive}\n" +
               $"Windows Directory: {WindowsDirectory}\n" +
               $"Locale: {LocaleName}\n" +
               $"Time Zone: {TimeZoneName}\n" +
               $"Status: {Status}\n" +
               $"Serial Number: {SerialNumber}";
    }
}