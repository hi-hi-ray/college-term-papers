using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KeepEverything.RaysaDutra.Domain.Entities
{
    public class Tag
    {
        public int IdTag { get; set; }
        [Required]
        public string NameTag { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
