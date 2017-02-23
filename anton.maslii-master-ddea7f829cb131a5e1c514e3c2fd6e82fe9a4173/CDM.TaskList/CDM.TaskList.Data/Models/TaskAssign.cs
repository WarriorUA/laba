using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDM.TaskList.Data.Models
{
    public class TaskAssign
    {
        [Key]
        public Guid TaskAssingId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? TaskId { get; set; }
        public string Comments { get; set; }
        public int? StatusId { get; set; }
        public DateTime AssignDate { get; set; }
        public DateTime CloseDate { get; set; }

        [ForeignKey("UserId")]
        public TaskUser TaskUser { get; set; }

        [ForeignKey("TaskId")]
        public Task Task { get; set; }

        [ForeignKey("StatusId")]
        public Status Status { get; set; }
    }
}
