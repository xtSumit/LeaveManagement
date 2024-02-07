using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Number of Days")]
        [Range(1, 50, ErrorMessage ="Invalid number entered")]
        public int NumberofDays { get; set; }
        [Required]
        [Display (Name ="Allocation Period")]
        public int Period { get; set; }
        public LeaveTypeViewModel? LeaveType { get; set; }
    }
}