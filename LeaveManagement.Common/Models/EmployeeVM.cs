using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class EmployeeVM
    {
        public string? Id { get; set; }

        [Display(Name = "First Name")]
        public string? Firstname { get; set; }
        [Display(Name = "Last Name")]
        public string? Lastname { get; set; }

        [Display(Name = "Email Adress")]
        public string? Email { get; set; }

        [Display(Name = "Date joined")]
        public DateTime DateJoined { get; set; }
     

    }
}
