using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace first_asp_app.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Number of days")]
        [Required]
        [Range(1,20,ErrorMessage = "Invalid number entered")]
        public int NumberOfDays { get; set; }
        [Display(Name = "Allocation period")]
        public int Period { get; set; }
   

        public LeaveTypeVM? LeaveType { get; set; }


    }
}