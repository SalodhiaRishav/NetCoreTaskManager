using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BAL;
using Shared.DTO;
using BAL.Interfaces;
using System.Net.Http;
using System.Net;

namespace UserTaskManger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        public ITaskBusinessLogic TaskBusinessLogic { get; set; }
        public TaskController(ITaskBusinessLogic taskBusinessLogic)
        {
            this.TaskBusinessLogic = taskBusinessLogic;
        }
        // GET: api/Task
        [HttpGet]
        public ActionResult<List<TaskDTO>> Get()
        {
            return this.TaskBusinessLogic.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<TaskDTO> Get(int id)
        {
            return this.TaskBusinessLogic.GetById(id);
        }

       

        // POST: api/Task
        [HttpPost]
        public void Post([FromBody]TaskDTO taskDTO)
        {
            this.TaskBusinessLogic.Add(taskDTO);
            return;
        }

        [HttpPut]
        public void Put(TaskDTO taskDTO)
        {
            this.TaskBusinessLogic.Update(taskDTO);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.TaskBusinessLogic.Delete(id);
        }
    }
}
