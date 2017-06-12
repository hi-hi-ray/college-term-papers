using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeepEverything.Consumer.RaysaDutra.Models
{
    public class TaskViewModel
    {
        public int IdTask { get; set; }
        public string NameTask { get; set; }
        public string DescriptionTask { get; set; }
        public string CurrentSituationTask { get; set; }
        public DateTime CreatedDateTask { get; set; }
        public DateTime EndedDateTask { get; set; }
        public virtual IEnumerable<TagViewModel> Tags { get; set; }
        public virtual CategoryViewModel Category { get; set; }
        public int IdCategory { get; set; }
        public int[] IdTags { get; set; }
    }
}