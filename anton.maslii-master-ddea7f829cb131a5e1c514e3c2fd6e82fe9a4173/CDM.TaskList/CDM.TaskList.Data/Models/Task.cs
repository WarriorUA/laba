using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDM.TaskList.Data.Models
{
    public class Task
    {
        [Key]
        public Guid TaskId { get; set; }
        public string TaskText { get; set; }
        public PriorityType Priority { get; set; }

        public Guid StatusTypeId { get; set; }

        [ForeignKey("StatusTypeId")]
        public StatusType StatusType { get; set; }
    }
}
