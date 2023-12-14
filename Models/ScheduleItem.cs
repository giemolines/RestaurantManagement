
namespace RestaurantManagement.Models
{
    // ScheduleItem.cs
    public class ScheduleItem
    {
        public int Id { get; set; }
        public string Employee { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int ScheduleId { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeRole { get; set; }
        public int ShiftId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int LocationId { get; set; }
    }


}
