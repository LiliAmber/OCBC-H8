using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace TodoApp.Controllers
{   
    //=define the routing that our controller going to use
    [Route("api/[controller]")]
    //==need to specify the type of the controller to let .Net core know
    [ApiController]
    public class TodoController : ControllerBase
    {
        //==define the routing for this section==
        [Route("TestRun")]
        [HttpGet]

        public ActionResult TestTun() 
        {
            return Ok("Success");
        }
    }
}
