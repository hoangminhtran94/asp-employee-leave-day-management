using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class LeaveAllocationEditVM:LeaveAllocationVM

    {
        [Required]
        public string EmployeeId { get; set; }
        public EmployeeVM? Employee { get; set; }
    }
}
