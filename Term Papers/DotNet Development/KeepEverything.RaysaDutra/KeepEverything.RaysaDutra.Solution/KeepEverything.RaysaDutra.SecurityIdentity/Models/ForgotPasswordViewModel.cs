using System.ComponentModel.DataAnnotations;

namespace KeepEverything.RaysaDutra.SecurityIdentity.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
