using System.ComponentModel.DataAnnotations;

namespace CatsApp.Web.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}