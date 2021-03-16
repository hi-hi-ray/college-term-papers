using System.ComponentModel.DataAnnotations;

namespace KeepEverything.RaysaDutra.SecurityIdentity.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}