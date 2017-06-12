using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace KeepEverything.RaysaDutra.Domain.Entities
{
    public class Task
    {
        
        public int IdTask { get; set; }
        [Required]
        public string NameTask { get; set; }
        [Required]
        public string DescriptionTask { get; set; }
        public string CurrentSituationTask { get; set; }
        public DateTime CreatedDateTask { get; set; }
        public DateTime EndedDateTask { get; set; }      
        
        #region Virtual
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual Category Category { get; set; }
        #endregion
        #region Foreign Key
        public int IdCategory { get; set; }
        #endregion

        public string[] Situations = new string[4] { "Em progresso", "Finalizada", "Atrasada", "Cancelada" };

        public string SeeTheSituationByDate(DateTime createdDateTask, DateTime endedDateTask)
        {
            int result = DateTime.Compare(createdDateTask, endedDateTask);
            if (result < 0)
                return "Em progresso";
            else if (result == 0)
                return "Finalizada";
            else
                return "Atrasada";
        }
    }
}
