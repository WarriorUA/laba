using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDM.TaskList.Data.Models;

namespace CDM.TaskList.Implementation.StatusesRepository
{
    public interface IStatusesRepository
    {
        List<Status> GetAllStatuses();

        List<Status> GetStatusesByStatusType(int statusTypeId);

        bool AddStatus(Status status);

        bool DeleteStatus(int statusId);
    }
}
