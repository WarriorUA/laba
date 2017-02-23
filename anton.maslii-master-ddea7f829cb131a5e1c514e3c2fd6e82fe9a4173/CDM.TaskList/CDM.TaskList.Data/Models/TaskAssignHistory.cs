using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDM.TaskList.Data.Models
{
    public class TaskAssignHistory
    {
        [Key]
        public Guid TaskAssignHistoryId { get; set; }
        public Guid TaskAssignId { get; set; }
        public Guid TaskUserId { get; set; }
        public string Comments { get; set; }
        public int StatusId { get; set; }
        public DateTime AssignDate { get; set; }
        public DateTime CloseDate { get; set; }
        public DateTime ChangeDate { get; set; }

        [ForeignKey("TaskAssignId")]
        public TaskAssign TaskAssign { get; set; }

        [ForeignKey("TaskUserId")]
        public TaskUser TaskUser { get; set; }

        [ForeignKey("StatusId")]
        public Status Status { get; set; }
    }
}
