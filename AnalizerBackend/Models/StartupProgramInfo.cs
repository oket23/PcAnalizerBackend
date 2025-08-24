namespace PcAnalyzer.Models;

public class StartupProgramInfo
{
    public string Name { get; set; }
    public string Command { get; set; }
    public string Location { get; set; }
    public string User { get; set; }
    public bool? Enabled { get; set; }

    public override string ToString()
    {
        string status = Enabled == true ? "Enabled" : Enabled == false ? "Disabled" : "Unknown";

        return $"Name: {Name}\n" +
               $"Command: {Command}\n" +
               $"Location: {Location}\n" +
               $"User: {User}\n" +
               $"Status: {status}";
    }
}
