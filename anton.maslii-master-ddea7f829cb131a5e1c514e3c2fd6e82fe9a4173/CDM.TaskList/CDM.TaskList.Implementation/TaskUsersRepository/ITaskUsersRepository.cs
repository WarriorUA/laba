using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDM.TaskList.Data.Models;

namespace CDM.TaskList.Implementation.TaskUsersRepository
{
    public interface ITaskUsersRepository
    {
        TaskUser GetUserBuId(Guid userId);

        List<TaskUser> GetAllUsers();

        bool AddTaskUser(TaskUser taskUser);

        bool DeleteUser(Guid taskUserId);
    }
}
