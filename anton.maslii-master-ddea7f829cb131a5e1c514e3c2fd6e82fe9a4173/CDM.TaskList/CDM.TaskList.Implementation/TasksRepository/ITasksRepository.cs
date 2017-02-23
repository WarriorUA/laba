using System;
using System.Collections.Generic;
using CDM.TaskList.Data.Models;
using Task = CDM.TaskList.Data.Models.Task;

namespace CDM.TaskList.Implementation.TasksRepository
{
    public interface ITasksRepository
    {
        Task GetTaskById(Guid id);

        List<Task> GetAllTasks(int startPosition, int recordCount);

        List<Task> GetTasksByPrioriryType(PriorityType priorityType, int startPosition, int recordCount);

        List<Task> GetTaskByStatusType(int statusTypeId, int startPosition, int recordCount);

        bool DeleteTasks(List<Task> tasks);

        bool UpsertTask(Task task);

        bool DeleteTaskById(Guid id);
    }
}
