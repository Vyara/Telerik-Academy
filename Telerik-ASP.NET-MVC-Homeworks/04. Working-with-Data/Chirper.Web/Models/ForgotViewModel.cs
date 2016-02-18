using System.ComponentModel.DataAnnotations;

namespace Chirper.Web.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}