using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using angular.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace angular_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(new { 
                Nombre = "Pedro",
                Apellido = "Perez",
                Email = "prueba@angular.com"
            });
        }

        [HttpPost("adduser")]
        public ActionResult Adduser([FromBody] UserViewModel user)
        {
            return Ok();
        }

        [HttpGet("users")]
        public ActionResult GetUsers()
        {
            List<UserViewModel> users = new List<UserViewModel>();

            users.Add(new UserViewModel
            {
                Apellido = "garcia",
                Email = "email@gmail.com",
                Nombre = "Federico"
            });

            users.Add(new UserViewModel
            {
                Apellido = "Juan",
                Email = "Juan@gmail.com",
                Nombre = "Juan"
            });

            users.Add(new UserViewModel
            {
                Apellido = "garcia",
                Email = "email@gmail.com",
                Nombre = "Federico"
            });

            return Ok(users);
        }
    }
}
