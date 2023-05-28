using first_asp_app.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace first_asp_app.Models
{
    public class LeaveRequestCreateVM
    {   
        public int Id{ get; set; }

        [Required]
        [Display(Name ="Start date")]
        public DateTime? StartDate { get; set; }
        [Required]
        [Display(Name = "End date")]
        public DateTime? EndDate { get; set; }


        public SelectList? LeaveTypes { get; set; }

        [Required]
        [Display(Name = "Leave type")]
        public int LeaveTypeId { get; set; }


        [Display(Name = "Request comments")]
        public string? RequestComments { get; set; }

    }

}
