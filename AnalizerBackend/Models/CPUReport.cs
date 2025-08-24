using System.Text;

namespace PcAnalyzer.Models;

public class CPUReport
{
    public int Count { get; set; }
    public int TotalCores { get; set; }
    public int TotalThreads { get; set; }
    public List<CPUInfo> CPUs { get; set; } = new();

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"CPUs: {Count}");
        sb.AppendLine($"Total Cores: {TotalCores}");
        sb.AppendLine($"Total Threads: {TotalThreads}");
        sb.AppendLine();

        for (int i = 0; i < CPUs.Count; i++)
        {
            sb.Append(CPUs[i].ToString());
            if (i != CPUs.Count - 1)
            {
                sb.AppendLine().AppendLine();
            }
        }

        return sb.ToString();
    }
}
