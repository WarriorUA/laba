using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDM.TaskList.Data.Models
{
    [Table("Statuses")]
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusText { get; set; }
        public int StatusOrder { get; set; }

        public Guid StatusTypeId { get; set; }

        [ForeignKey("StatusTypeId")]
        public StatusType StatusType { get; set; }
    }
}
