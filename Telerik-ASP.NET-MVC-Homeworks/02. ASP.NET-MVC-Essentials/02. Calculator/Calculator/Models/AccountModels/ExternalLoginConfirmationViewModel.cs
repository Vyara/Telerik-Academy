using System.ComponentModel.DataAnnotations;

namespace Calculator.Models.AccountModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}