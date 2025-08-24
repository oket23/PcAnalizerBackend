namespace PcAnalyzer.Models
{
    public class OSReport
    {
        public OSInfo OS { get; set; }

        public override string ToString()
        {
            return OS?.ToString() ?? "No OS information available.";
        }
    }
}