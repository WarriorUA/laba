using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDM.TaskList.Data.Models
{
    public class StatusType
    {
        [Key]
        public Guid StatusTypeId { get; set; }
        public string StatusTypeName { get; set; }
        public string StatusTypeKey { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
