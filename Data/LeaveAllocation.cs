using System.ComponentModel.DataAnnotations.Schema;

namespace first_asp_app.Data
{
    public class LeaveAllocation:BaseEntity
    {

        public int NumberOfDays { get; set; }

        public string EmployeeId { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }

        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
