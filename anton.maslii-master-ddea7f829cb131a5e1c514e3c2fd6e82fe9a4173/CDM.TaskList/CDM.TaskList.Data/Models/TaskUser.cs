using System;
using System.ComponentModel.DataAnnotations;

namespace CDM.TaskList.Data.Models
{
    public class TaskUser
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
    }
}
