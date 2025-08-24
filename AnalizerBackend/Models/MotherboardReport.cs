using PcAnalyzer.Models;
using System.Text;

namespace PcAnalyzer.Modelsp;

public class MotherboardReport
{
    public int Count { get; set; }
    public List<MotherboardInfo> Motherboards { get; set; } = new();

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Motherboards: {Count}");
        sb.AppendLine();

        for (int i = 0; i < Motherboards.Count; i++)
        {
            sb.Append(Motherboards[i].ToString());
            if (i != Motherboards.Count - 1)
            {
                sb.AppendLine().AppendLine();
            }
        }

        return sb.ToString();
    }
}
