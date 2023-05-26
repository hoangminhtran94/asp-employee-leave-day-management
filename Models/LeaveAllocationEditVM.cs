using System.ComponentModel.DataAnnotations;

namespace first_asp_app.Models
{
    public class LeaveAllocationEditVM:LeaveAllocationVM

    {
        [Required]
        public string EmployeeId { get; set; }
        public EmployeeVM? Employee { get; set; }
    }
}
