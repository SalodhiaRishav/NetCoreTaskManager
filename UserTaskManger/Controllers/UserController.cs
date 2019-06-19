using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BAL.Interfaces;
using Shared.DTO;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UserTaskManger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBusinessLogic UserBusinessLogic;
        public UserController(IUserBusinessLogic userBusinessLogic)
        {
            UserBusinessLogic = userBusinessLogic;
        }

        // GET: api/User
        [HttpGet]
        public ActionResult<List<UserDTO>> Get()
        {
            return this.UserBusinessLogic.GetAll();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<UserDTO> Get(int id)
        {
            UserDTO userDTO=this.UserBusinessLogic.GetById(id);            
            return userDTO;

        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] UserDTO userDTO)
        {
            this.UserBusinessLogic.Add(userDTO);
        }

        // PUT: api/User/5
        [HttpPut]
        public void Put(UserDTO userDTO)
        {
            this.UserBusinessLogic.Update(userDTO);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.UserBusinessLogic.Delete(id);
        }
    }
}
