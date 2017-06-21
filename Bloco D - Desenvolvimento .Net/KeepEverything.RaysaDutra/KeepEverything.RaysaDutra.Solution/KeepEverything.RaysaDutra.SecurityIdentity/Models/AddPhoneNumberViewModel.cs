using System.ComponentModel.DataAnnotations;

namespace KeepEverything.RaysaDutra.SecurityIdentity.Models
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}