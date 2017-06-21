using System.Collections.Generic;

namespace KeepEverything.RaysaDutra.SecurityIdentity.Models
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<string> Providers { get; set; }
    }
}