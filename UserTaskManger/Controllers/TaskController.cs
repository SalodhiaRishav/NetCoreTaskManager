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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Task/5
        //public HttpResponseMessage Get(int id)
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, this.TaskBusinessLogic.GetById(id));

        //}
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Task
        [HttpPost]
        public void Post([FromBody]TaskDTO taskDTO)
        {
            this.TaskBusinessLogic.Add(taskDTO);
            return;
        }

        // PUT: api/Task/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
