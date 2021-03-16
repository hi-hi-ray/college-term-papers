using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KeepEverything.RaysaDutra.Domain.Entities
{
    public class Category
    {
        public int IdCategory { get; set; }
        [Required]
        public string NameCategory { get; set; }
        [Required]
        public string DescriptionCategory { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
