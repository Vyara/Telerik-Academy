using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Web.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}