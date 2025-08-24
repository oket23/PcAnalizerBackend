using System.Text;

namespace PcAnalyzer.Models;

public class GPUReport
{
    public int Count { get; set; }
    public long TotalMemoryMB { get; set; }
    public List<GPUInfo> GPUs { get; set; } = new();

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"GPUs: {Count}");
        sb.AppendLine($"Total GPU Memory: {TotalMemoryMB} MB");
        sb.AppendLine();

        for (int i = 0; i < GPUs.Count; i++)
        {
            sb.Append(GPUs[i].ToString());
            if (i != GPUs.Count - 1)
            {
                sb.AppendLine().AppendLine();
            }
        }

        return sb.ToString();
    }
}
