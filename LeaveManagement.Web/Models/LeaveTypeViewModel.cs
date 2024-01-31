using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Range(1,25, ErrorMessage = "Please enter a valid number!")]
        [Display(Name = "Default Number of Days")]
        [Required]
        public int DefaultDays { get; set; }
    }
}
