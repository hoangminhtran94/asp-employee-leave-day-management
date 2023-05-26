using System.ComponentModel.DataAnnotations.Schema;

namespace first_asp_app.Models
{
    public class LeaveAllocationVM
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }

        public int Period { get; set; }
   

        public LeaveTypeVM LeaveType { get; set; }


    }
}