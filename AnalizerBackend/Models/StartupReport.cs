using System.Text;

namespace PcAnalyzer.Models;

public class StartupReport
{
    public int Count { get; set; }
    public int EnabledCount { get; set; }
    public int DisabledCount { get; set; }
    public List<StartupProgramInfo> Programs { get; set; } = new();

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Startup Programs: {Count} (Enabled: {EnabledCount}, Disabled: {DisabledCount})");
        sb.AppendLine();

        for (int i = 0; i < Programs.Count; i++)
        {
            sb.Append(Programs[i].ToString());
            if (i != Programs.Count - 1)
            {
                sb.AppendLine().AppendLine();
            }
        }

        return sb.ToString();
    }
}
