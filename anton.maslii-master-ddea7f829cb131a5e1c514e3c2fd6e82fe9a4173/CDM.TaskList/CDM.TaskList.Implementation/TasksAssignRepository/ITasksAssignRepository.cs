using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CDM.TaskList.Data.Models;
using Task = System.Threading.Tasks.Task;

namespace CDM.TaskList.Implementation.TasksAssignRepository
{
    public interface ITasksAssignRepository
    {
        TaskAssign GetTaskAssignById(Guid id);

        List<TaskAssign> GetAssignedTasks(int startPosition, int recordCount);

        List<TaskAssign> GetAssignedTasksByUser(Guid userId, int startPosition, int recordCount);

        List<TaskAssign> GetAssignedTasksByStatus(int statusId, int startPosition, int recordCount);

        List<TaskAssign> GetAssignedTasksByAssignDate(DateTime date, int startPosition, int recordCount);

        List<TaskAssign> GetAssignedTasksByCloseDate(DateTime? date, int startPosition, int recordCount);

        bool AssignTask(TaskAssign taskAssign);

        bool DeleteAssignedTask(Guid taskAssignId);
    }
}
