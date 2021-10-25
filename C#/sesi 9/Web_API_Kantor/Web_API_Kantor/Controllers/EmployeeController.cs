using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Web_API_Kantor.Models;

namespace Web_API_Kantor.Controllers
{
    //==DEFAULT==
    //public class HomeController : Controller
    //{
    //    private readonly ILogger<HomeController> _logger;

     //   public HomeController(ILogger<HomeController> logger)
       // {
     //       _logger = logger;
       // }

       // public IActionResult Index()
       // {
           // return View();
        //}

       // public IActionResult Privacy()
       // {
           // return View();
        //}

       // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
       // public IActionResult Error()
       // {
           // return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    //}

    //==CUSTOM(SESUAI SLIDE KODE.ID 9TH MEETING)
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }

        //== GET: api/user
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            //==return new string[]
            return _context.GetEmployee();
        }
        //== GET: api/user/{id}
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetEmployee(id);
        }
    }
}
