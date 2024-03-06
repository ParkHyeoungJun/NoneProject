using Microsoft.AspNetCore.Mvc;
using MvcProject.Service;

namespace MvcProject.Controllers
{
    public class DIController : Controller
    {
        private CopyRightService _svc;

        public DIController(CopyRightService service)
        {
                _svc=service;
        }
        [Route("/"),Route("Index"),Route("Default")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
