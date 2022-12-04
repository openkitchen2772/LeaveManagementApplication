using System.ComponentModel.DataAnnotations;

namespace LeaveManagementApplication.Models
{
    public class LeaveTypeViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Default Number of Days")]
        [Required]
        [Range(1, 25, ErrorMessage = "Please input valid number of days.")]
        public int? DefaultOfDays { get; set; }

    }
}
