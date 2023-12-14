// RequestModel.cs
namespace RestaurantManagement.Models
{
    public class ScheduleChangeRequestModel
    {
        public string EmployeeName { get; set; }
        public string RequestType { get; set; } // "DayOff" or "NewSchedule"
        public string NewSchedule { get; set; } // If RequestType is "NewSchedule"
        public string SelectedShift { get; set; } // Added property for selected shift
        public DateTime SelectedDate { get; set; } // Added property for selected date
    }
}
