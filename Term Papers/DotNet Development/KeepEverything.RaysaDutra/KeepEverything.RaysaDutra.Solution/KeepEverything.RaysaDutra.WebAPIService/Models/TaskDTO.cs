using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeepEverything.RaysaDutra.WebAPIService.Models
{
    public class TaskDTO
    {
        public int IdTask { get; set; }
        public int IdCategory { get; set; }
        public string NameTask { get; set; }
        public string DescriptionTask { get; set; }
        public string CurrentSituationTask { get; set; }
        public DateTime CreatedDateTask { get; set; }
        public DateTime EndedDateTask { get; set; }
        public virtual ICollection<TagDTO> Tags { get; set; }
        public virtual CategoryDTO Category { get; set; }
    }
}