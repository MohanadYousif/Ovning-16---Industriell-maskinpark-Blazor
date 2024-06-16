namespace MachinePark.Models
{
    public class Machine
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public bool IsOnline { get; set; }
        public string? LatestData { get; set; }
    }
}
