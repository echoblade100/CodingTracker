namespace CodingTracker.Models
{
    public class Habit : BaseTable
    {
        public string Name { get; set; } = null!;
        public string MeasurementMethod { get; set; } = null!;
    }
}
