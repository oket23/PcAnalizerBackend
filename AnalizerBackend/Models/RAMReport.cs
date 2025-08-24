namespace PcAnalyzer.Models;

public class RAMReport
{
    public int Count { get; set; }
    public double TotalCapacityGB { get; set; }
    public List<RAMInfo> Modules { get; set; } = new();

    public override string ToString()
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine($"Total Modules: {Count}");
        sb.AppendLine($"Total Capacity: {TotalCapacityGB} GB");
        sb.AppendLine();

        for (int i = 0; i < Modules.Count; i++)
        {
            sb.Append(Modules[i].ToString());
            if (i != Modules.Count - 1)
            {
                sb.AppendLine().AppendLine();
            }
        }
        return sb.ToString();
    }
}
