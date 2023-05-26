using System.ComponentModel.DataAnnotations;

namespace first_asp_app.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave type")]
        [Required]
        public string? Name { get; set; }
        [Display(Name = "Default number Of Days")]
        [Range(1,25,ErrorMessage ="Please enter a valid number")]
        [Required]
        public int DefaultDays { get; set; }
    }
}
