namespace CodingTracker.Models
{
    public class HabitRecord : BaseTable
    {
        public DateTime Date { get; set; }
        public int NumberOfApproachesPerDay { get; set; }
        public int HabitId { get; set; }
    }
}
