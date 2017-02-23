using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CDM.TaskList.Data.EF;
using CDM.TaskList.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CDM.TaskList.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var outputTestData = new List<string>();

            using (var db = new TasksContext())
            {
                var statusType = new StatusType { StatusTypeId = Guid.NewGuid()};
                db.StatusTypes.Add(statusType);

                var firstTask = new Task
                {
                    TaskId = Guid.NewGuid(),
                    Priority = PriorityType.Low,
                    TaskText = "FirstTaskTest",
                    StatusTypeId = statusType.StatusTypeId
                    
                };
                var secontTask = new Task
                {
                    TaskId = Guid.NewGuid(),
                    Priority = PriorityType.Medium,
                    TaskText = "SecondTaskTest",
                    StatusTypeId = statusType.StatusTypeId
                };

                db.Tasks.Add(firstTask);
                db.Tasks.Add(secontTask);
                db.SaveChanges();

                var tasks = db.Tasks;
                foreach (var task in tasks)
                {
                    outputTestData.Add($"Id: {task.TaskId.ToString()} | Text: {task.TaskText}");
                }
                return outputTestData;
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value1";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
