using System.Text;

namespace PcAnalyzer.Models;

public class DiskReport
{
    public int Count { get; set; }
    public double TotalCapacityGB { get; set; }
    public List<DiskInfo> Disks { get; set; } = new();

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Total Disks: {Count}");
        sb.AppendLine($"Total Capacity: {TotalCapacityGB} GB");
        sb.AppendLine();

        for (int i = 0; i < Disks.Count; i++)
        {
            sb.Append(Disks[i].ToString());
            if (i != Disks.Count - 1)
            {
                sb.AppendLine().AppendLine();
            }
        }
        return sb.ToString();
    }
}