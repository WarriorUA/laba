using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDM.TaskList.Data.Models;
using Task = CDM.TaskList.Data.Models.Task;

namespace CDM.TaskList.Data.EF
{
    public class TasksContext : DbContext
    {
        public TasksContext()
            :base("Tasks")
        { }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskUser> TaskUsers { get; set; }
        public DbSet<TaskAssign> TaskAssigns { get; set; }
        public DbSet<TaskAssignHistory> TaskAssignHistories { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<TaskStatusHistory> TaskStatusHistories { get; set; }
        public DbSet<StatusType> StatusTypes { get; set; }
    }
}
